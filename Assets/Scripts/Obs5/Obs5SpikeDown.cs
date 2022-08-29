using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs5SpikeDown : MonoBehaviour
{
    public Transform spikeTrans;

    private void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            spikeTrans.transform.position += new Vector3(0f, -3f, 0f);
        }
    }
}
