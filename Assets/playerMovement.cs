using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Vector2 jump;
    private Vector2 position;
    public float jumpForce = 2.0f;

    public Animator animator;

    public bool isGrounded;
    public Rigidbody2D rb2d;

    void Start()
    {
        jump = new Vector2(0.0f, 300.0f);
    }

    void OnCollisionEnter2D()
    {
        isGrounded = true;
        animator.SetBool("jumping", false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("i") && isGrounded)
        {
            animator.SetBool("jumping", true);
            position = rb2d.position;
            rb2d.MovePosition(new Vector2 (position.x,2.5f));
            isGrounded = false;
        }

        if (Input.GetKeyDown("e"))
        {
            position = rb2d.position;
            rb2d.MovePosition(new Vector2(position.x, 0.0f));
        }

    }
}
