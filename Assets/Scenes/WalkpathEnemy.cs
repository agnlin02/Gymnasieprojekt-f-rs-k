using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkpathEnemy : MonoBehaviour
{
   
   public float speed;

   private bool MovingRight = true;

   public Transform groundDetection;

   public float distance;

   void Update ()
   {
       transform.Translate(Vector2.right * speed * Time.deltaTime);

       RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
       if(groundInfo.collider == false)
       {
           if(MovingRight == true)
           {
               transform.eulerAngles = new Vector3(0, -180, 0);
               MovingRight = false;
           }
           else
           {
               transform.eulerAngles = new Vector3(0, 0, 0);
               MovingRight = true;
           }
       }
   }




}
