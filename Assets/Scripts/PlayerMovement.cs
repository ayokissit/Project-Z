using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 20f;
    private Vector2 movement;
    Animator playerAnimator;
    private bool isFacingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        Walk();

        if (isFacingRight == false && movement.x > 0)
        {
            RotatePlayer();
        }
        else if (isFacingRight == true && movement.x < 0)
        {
            RotatePlayer();
        }

        playerAnimator.SetBool("Run", Mathf.Abs(movement.x) >= 0.1f);

    }

    void RotatePlayer()
    {
        isFacingRight = !isFacingRight;

        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;

        transform.localScale = playerScale;
    }

    void Walk()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
        
    }
}
