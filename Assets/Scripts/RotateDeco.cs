using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDeco : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * moveSpeed * Time.deltaTime);    
    }
}
