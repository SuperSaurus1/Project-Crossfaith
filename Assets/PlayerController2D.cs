using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
   // Animator animator;
    Rigidbody2D rb2d;
    //SpriteRenderer spriteRenderer;
    //bool isGrounded;
    public float speed;
    public float jumpForce;
    Vector3 NewForce;
    

    [SerializeField]
    //Transform GroundCheck;

        

    // Start is called before the first frame update
    void Start()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        //spriteRenderer = GetComponent<SpriteRenderer>();
        NewForce = new Vector3(horizontal, 1f, 0f);

    }

    void FixedUpdate()
    {
      
        //var maxSpeed = currentMaxSpeed;
        //var acc = maxSpeed;
        /*if (Physics2D.Linecast(transform.position, GroundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
         isGrounded = true;
        }
        else
            {
              isGrounded = false;
            }
        */
       
        //transform.Translate(Vector2.right * Time.deltaTime * speed * horizontal);
        if (Input.GetButtonDown("Horizontal"))
        rb2d.AddForce(NewForce, (ForceMode2D)ForceMode.Acceleration);
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb2d.velocity.y) < .1)
        {
            rb2d.AddRelativeForce(Vector2.up * jumpForce);
        }
        /*if (Input.GetKey("d") && rb2d.velocity.x <= 7 || Input.GetKey("right") && rb2d.velocity.x <= 7)
        {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            spriteRenderer.flipX = false;
        }
                    
                
               
                else if (Input.GetKey("a") || Input.GetKey("left"))
                {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
                    spriteRenderer.flipX = true;
                }
        
                else
                {
                    rb2d.velocity = new Vector2(0, rb2d.velocity.y);
                }
        */

     }
}

