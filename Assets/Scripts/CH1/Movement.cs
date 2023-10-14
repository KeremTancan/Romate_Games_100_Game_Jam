using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent < SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = 0f;
        anim.SetBool("isMoving", false);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            horizontalInput = 1f;
            anim.SetBool("isMoving", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            horizontalInput = -1f;
            anim.SetBool("isMoving", true);
        }

        Vector2 moveDirection = new Vector2(horizontalInput, 0);
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
