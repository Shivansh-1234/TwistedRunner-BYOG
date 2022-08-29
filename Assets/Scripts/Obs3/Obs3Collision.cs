using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs3Collision : MonoBehaviour
{
    public GameObject[] obsPrefab;

    private AudioSource woodHitAudio;

    void Start()
    {
        woodHitAudio = GameObject.Find("WoodHitAudio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            foreach (var o in obsPrefab)
            {
                o.AddComponent<Rigidbody>();
                o.GetComponent<Rigidbody>().useGravity = false;
                o.GetComponent<Rigidbody>().mass = 0.01f;
            }

            woodHitAudio.Play();
        }

    }
}
