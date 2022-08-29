using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private Transform leftWallTransform;
    private Transform righttWallTransform;

    public float moveSpeed = 550f;

    void Start()
    {
        leftWallTransform   = transform.Find("Left Wall");
        righttWallTransform = transform.Find("Right Wall");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void checkCollision()
    {
        leftWallTransform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        righttWallTransform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
