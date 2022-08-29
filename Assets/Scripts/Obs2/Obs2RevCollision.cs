using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs2RevCollision : MonoBehaviour
{
    private AudioSource thud;

    void Start()
    {
        thud = GameObject.Find("IronShutAudio").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            transform.localRotation = Quaternion.Euler(new Vector3(80, -90, 0));
            GetComponent<MeshCollider>().enabled = false;
            thud.Play();
        }
    }
}
