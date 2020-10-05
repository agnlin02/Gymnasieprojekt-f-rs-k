using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyattack : MonoBehaviour
{
    private PlayerHealth player; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>(); //Hämtar spelar Gameobjektet från Playerhealt scriptet. Detta för att kunna navända det i OnTriggerenter2D senare.
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) //Skapar en void med parametern Collider2d som kallas col. 
    {
        if(col.CompareTag("Player") && GameObject.Find("Player").GetComponent<PlayerHealth>().CurrentHealth > 0 ) //Om Col (Collidern som vi skapade innan som en parameter) collidar med GameObjektet som har Tagen "Player"
        {
            player.Damage(3); //jag hämtar den publika(allmänna) voiden som finns i PlayerHealth och sätter paramteren dmg till 3. Alltså gör den 3 dammage.
            
              Debug.Log(GameObject.Find("Player").GetComponent<PlayerHealth>().CurrentHealth); //Hämtar spelarens hälsa i scriptet "Player health"
            
        }
        else if (GameObject.Find("Player").GetComponent<PlayerHealth>().CurrentHealth <= 0)
        {
            Debug.Log("Game Over");
        }
    }


    public void jumpOnHead()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }

}
