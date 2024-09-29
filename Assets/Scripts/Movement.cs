using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;
    public float jumpForce;

    bool isGrounded = false;
    bool isInWater = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;
    public float fCutJumpHeight;
    public float downCutJumpHeight;

    public int defaultAdditionalJumps = 1;
    int additionalJumps;

    public float jumpPadForce;

    // Start is called before the first frame update
    void Start()

    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();

        if (Input.GetKeyDown(KeyCode.R))
            {
            transform.position = new Vector2(-134, -39);
            isInWater = false;
        }
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || additionalJumps > 0 || isInWater == true))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            additionalJumps--;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {

            if (rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * fCutJumpHeight);
            }
        }

    }

    void CheckIfGrounded()
    {
        
            Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
            if (collider != null)
            {
                isGrounded = true;
                additionalJumps = defaultAdditionalJumps;
            }
            else
            {
                isGrounded = false;
            }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "JumpPad")
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPadForce);
            additionalJumps = defaultAdditionalJumps;
        }

        if (collision.gameObject.tag == "JumpPad2")
        {
            rb.velocity = new Vector2(rb.velocity.x, - jumpPadForce);
            additionalJumps = defaultAdditionalJumps;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "JumpOrb")
        {
            additionalJumps = defaultAdditionalJumps;
            //collision.gameObject.enabled(false);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (collision.gameObject.tag == "Water")
        {
            isInWater = true;
        }

        if (collision.gameObject.tag == "Air")
        {
            isInWater = false;
        }



    }

    
}   
    
