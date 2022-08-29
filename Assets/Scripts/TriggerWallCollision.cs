using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWallCollision : MonoBehaviour
{
    private WallCollision wallCollider;
    //private AudioSource explosionSfx;

    private GamOver g;

    private void Start()
    {
        wallCollider = GetComponentInParent<WallCollision>();
        //explosionSfx = GameObject.Find("ExplosionAudio").GetComponent<AudioSource>();
        g = GameObject.Find("HandleGameOver").GetComponent<GamOver>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wallCollider.checkCollision();
            Destroy(other.gameObject);
            g.GameOverNormal();
        }
    }
}
