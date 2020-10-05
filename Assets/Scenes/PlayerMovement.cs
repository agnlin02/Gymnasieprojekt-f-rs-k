using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    private Rigidbody2D rigidbody2d;
    public float moveSpeed = 5f;
    public float jumpVelocity = 10f;
    public bool isGrounded = false;
    // Start is called before the first frame update

    private BoxCollider2D boxCollider2D;
    void Start()
    {
       rigidbody2d = transform.GetComponent<Rigidbody2D>();
       boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

   

        if (Input.GetKeyDown(KeyCode.Space) && Ground())
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }

    }

    private bool Ground(){
       RaycastHit2D raycastHit2D= Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, layerMask);
       return raycastHit2D.collider !=null;
    }


   

}
