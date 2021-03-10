using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    bool isGrounded;
    
    [SerializeField]
    Transform GroundCheck;

        

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();


    }
    
    private void FixedUpdate()
    {
        int speed = 2;
        //var maxSpeed = currentMaxSpeed;
        //var acc = maxSpeed;
        if (Physics2D.Linecast(transform.position, GroundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
         isGrounded = true;
        }
        else
            {
              isGrounded = false;
            }

        if (Input.GetKey("d") && rb2d.velocity.x <= 7 || Input.GetKey("right") && rb2d.velocity.x <= 7)
        {
            if (rb2d.velocity.x <= 10)
            {
                rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
                spriteRenderer.flipX = false;
                
            }
        }
                     //if (Input.GetKey("d") && rb2d.velocity.x == 10)
                     //{
                       // rb2d.velocity = new Vector2((float)(rb2d.velocity.x + 0.25), rb2d.velocity.y);
                     //}
                
               
                else if (Input.GetKey("a") || Input.GetKey("left"))
                {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
                    spriteRenderer.flipX = true;
                }

                else
                {
                    rb2d.velocity = new Vector2(0, rb2d.velocity.y);
                }
                if (Input.GetKey("space") && isGrounded)
                {
                    rb2d.velocity = new Vector2(rb2d.velocity.x, 3);

                }
            }
    }

