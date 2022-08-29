using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj5SpikeLogic : MonoBehaviour
{
    public ToggleSpikes toggleSpikebool;
    public Transform spikeTrans;

    private GamOver g;

    void Start()
    {
        g = GameObject.Find("HandleGameOver").GetComponent<GamOver>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (toggleSpikebool.isSpikeUp)
            {
                spikeTrans.transform.position += new Vector3(0f, -3f, 0f);
            }

            else if (!toggleSpikebool.isSpikeUp)
            {
                spikeTrans.transform.position += new Vector3(0f, 3f, 0f);
                Destroy(collision.gameObject);
                g.GameOverNormal();
            }
        }
    }
}
