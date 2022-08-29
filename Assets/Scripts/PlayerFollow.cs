using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    private Transform playerTrans;
    public Vector3 offset = Vector3.zero;

    void Start()
    {
        playerTrans = GameObject.Find("Player").GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTrans.position + offset;
    }
}
