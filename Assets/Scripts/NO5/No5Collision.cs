using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No5Collision : MonoBehaviour
{
    public ToggleSpikes toggleSpikebool;
    public Transform spikeTrans;

    private GamOver g;

    private void Start()
    {
        g = GameObject.Find("HandleGameOver").GetComponent<GamOver>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (toggleSpikebool.isSpikeUp)
            {
                spikeTrans.transform.position += new Vector3(0f, -3f, 0f);
                Destroy(collision.gameObject);
                g.GameOverNormal();
            }

            else if (!toggleSpikebool.isSpikeUp)
            {
            }
        }
    }
}
