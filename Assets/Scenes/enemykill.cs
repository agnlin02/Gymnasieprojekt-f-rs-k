using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemykill : MonoBehaviour
{
    private PlayerHealth Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<BoxCollider2D>().enabled = false;

           // JumpOnHead();

        }
    }
}
