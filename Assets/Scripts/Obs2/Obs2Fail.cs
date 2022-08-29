using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs2Fail : MonoBehaviour
{
    private PlayerController playerController;

    //private AudioSource bgmusic;
    //private AudioSource deathSound;

    private GamOver g;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //deathSound = GameObject.Find("DeathSound").GetComponent<AudioSource>();
        //bgmusic = GameObject.Find("BgMusic").GetComponent<AudioSource>();
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
            if(playerController.playerForwardMoveSpeed > 80f)
            {
                KillPlayer();
            }

            else
            {
                Invoke(nameof(KillPlayer), 0.1f);
            }

            g.GameOverReversed();
        }
    }

    void KillPlayer()
    {
        playerController.playerForwardMoveSpeed = 0f;
        playerController.playerSidewardsMoveSpeed = 0f;
        playerController.playerJumpSpeed = 0f;
        GameObject.Find("Player").GetComponent<BoxCollider>().enabled = false;
        Destroy(gameObject);
    }
}
