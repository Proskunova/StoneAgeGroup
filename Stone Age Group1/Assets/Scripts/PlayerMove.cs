using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof (Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerJumpForce;

    [SerializeField] private GameObject animObject;

    private SpriteRenderer spriteRenderer;


    private float currentPlayerSpeed;
    private Rigidbody2D rb;
    private bool groundCheck;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = animObject.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // Enum using
        rb.velocity = new Vector2(currentPlayerSpeed * Time.deltaTime, rb.velocity.y);
        //rb.AddForce(new Vector2(currentPlayerSpeed, 0f), ForceMode2D.Force);
    }

    public void RightMove()
    {
        currentPlayerSpeed = playerSpeed;
        spriteRenderer.flipX = false;
       
    }
    public void LeftMove()
    {
        currentPlayerSpeed = - playerSpeed;
        spriteRenderer.flipX = true;
       
    }
  
    public void StopMove()
    {
        currentPlayerSpeed = 0f;
        //rb.velocity = new Vector2(currentPlayerSpeed, rb.velocity.y);
    }

    public void Jump()
    {
        if (groundCheck)
        {
            rb.velocity = new Vector2(rb.velocity.x, playerJumpForce);
            groundCheck = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        groundCheck = true;
    }





}

//if (transform.localScale.x < 0)
//{
//    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
//}
//if (transform.localScale.x > 0)
//{
//    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
//}