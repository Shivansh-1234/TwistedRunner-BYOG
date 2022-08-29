using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs6Collision : MonoBehaviour
{
    public GameObject roller;
    private bool collided = false;

    private AudioSource rotatingAudio;

    void Start()
    {
        rotatingAudio = GameObject.Find("RotatingAudio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collided)
        {
            roller.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 20f, 50f));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            roller.AddComponent<Rigidbody>();
            collided = true;

            rotatingAudio.Play();
        }      
    }
}
