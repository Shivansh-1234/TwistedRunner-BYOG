using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NO1Destroy : MonoBehaviour
{
    private GamOver g;

    void Start()
    {
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
            Destroy(collision.gameObject);
            g.GameOverNormal();
        }
    }
}
