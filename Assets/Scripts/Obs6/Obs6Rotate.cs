using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs6Rotate : MonoBehaviour
{
    public float rotateSpeed = 20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }
}
