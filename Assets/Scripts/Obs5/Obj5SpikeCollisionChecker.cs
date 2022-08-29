using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj5SpikeCollisionChecker : MonoBehaviour
{
    [HideInInspector]public bool isSpikeTouching = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Spike"))
        {
            isSpikeTouching = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Spike"))
        {
            isSpikeTouching = false;
        }
    }
}
