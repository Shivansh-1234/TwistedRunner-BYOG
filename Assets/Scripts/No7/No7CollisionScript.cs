using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No7CollisionScript : MonoBehaviour
{
    private PlayerController playerController;
    private GamOver g;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        g = GameObject.Find("HandleGameOver").GetComponent<GamOver>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (playerController.playerForwardMoveSpeed > 80f)
        {
            KillPlayer();
        }

        else
        {
            Invoke(nameof(KillPlayer), 0.1f);
        }
    }

    void KillPlayer()
    {
        playerController.playerForwardMoveSpeed = 0f;
        playerController.playerSidewardsMoveSpeed = 0f;
        playerController.playerJumpSpeed = 0f;
        GameObject.Find("Player").GetComponent<BoxCollider>().enabled = false;
        Destroy(gameObject);
        g.GameOverNormal();
    }
}
