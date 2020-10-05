using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
     public int CurrentHealth = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Damage (int dmg) //skapar en void som hämtar in en parameter från enemyatackscript
    {
        CurrentHealth -= dmg; //sätter curenthealt som curenthealt minus parametersn som blir inskcikad från enemyattack script.
        
    }

}
