using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement Handlers")]
    public float playerForwardMoveSpeed = 5f;
    public float playerSidewardsMoveSpeed = 3f;
    public float playerIncreaseSpeed = 1f;
    public float playerJumpSpeed = 5f;

    private float targetSpeed = 110f;

    private GamOver gameOver;
    private bool playerGirgaya = false;

    private Rigidbody rb;

    //FOR MOBILE
    private float screenWidth;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        gameOver = GameObject.Find("HandleGameOver").GetComponent<GamOver>();

        //FM
        screenWidth = Screen.width;
    }

    void Update()
    {
        MovePlayerForward();

        ChangePlayerSides();

        PlayerJump();

        if(transform.position.y <= -35f && !playerGirgaya)
        {
            gameOver.GameOverNormal();
            playerGirgaya =true;
            Destroy(gameObject);
        }
    }

    void MovePlayerForward()
    {
        //TURN IT ON LATER!
        if (playerForwardMoveSpeed < targetSpeed)
        {
            playerForwardMoveSpeed += playerIncreaseSpeed * Time.deltaTime;
        }

        transform.Translate(Vector3.forward * playerForwardMoveSpeed * Time.deltaTime);
    }

    void ChangePlayerSides()
    {
        /*float horizontalInput = Input.GetAxis("Horizontal") * playerSidewardsMoveSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * horizontalInput);*/

        //For Mobile
        int i = 0;
        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > screenWidth / 2)
            {
                transform.Translate(Vector3.right * playerSidewardsMoveSpeed * Time.deltaTime);
            }

            if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                transform.Translate(Vector3.left * playerSidewardsMoveSpeed * Time.deltaTime);
            }
            ++i;
        }
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0f, playerJumpSpeed, 0f), ForceMode.Impulse);
        }
    }

}
