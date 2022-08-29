using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpikes : MonoBehaviour
{
    public bool isSpikeUp = true;

    void Start()
    {
        StartCoroutine(ToggleSpikess());
    }

    // Update is called once per frame
    void Update()
    {
    }

    void checkSpikes()
    {
        if (!isSpikeUp)
        {
            transform.position += new Vector3(0f, 3f, 0f);
            isSpikeUp = true;
        }

        else if (isSpikeUp)
        {
            transform.position += new Vector3(0f, -3f, 0f);
            isSpikeUp = false;
        }
    }

    public IEnumerator ToggleSpikess()
    {
        yield return new WaitForSeconds(1f);

        checkSpikes();

        StartCoroutine(ToggleSpikess());

    }
}
