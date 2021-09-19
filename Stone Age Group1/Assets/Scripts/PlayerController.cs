using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idle,
    MoveLeft,
    MoveRighr,
    Jump,
    Attack

}

[RequireComponent(typeof (Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public static PlayerState GetState { get; private set; }

    [Header("Player")]
    [SerializeField] private float playerSpeed = 200f;
    [SerializeField] private float playerJumpForce = 7.2f;
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerState currentState;

    Quaternion rotationLeft = Quaternion.Euler(new Vector3(0, 180, 0));
    Quaternion rotationRight = Quaternion.Euler(Vector3.zero);

    private float currentPlayerSpeed;
    private Rigidbody2D rb;
    public static bool groundCheck;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(currentPlayerSpeed * Time.deltaTime, rb.velocity.y);
    }

    public void RightMove()
    {
        currentPlayerSpeed = playerSpeed;
        animator.transform.rotation = rotationRight;
        animator.SetBool("IsWalk", true);
        SetNewState(PlayerState.MoveRighr);

    }
    public void LeftMove()
    {
        currentPlayerSpeed = - playerSpeed;
        animator.transform.rotation = rotationLeft;
        animator.SetBool("IsWalk", true);
        SetNewState(PlayerState.MoveLeft);

    }
  
    public void StopMove()
    {
        currentPlayerSpeed = 0f;
        animator.SetBool("IsWalk", false);
        SetNewState(PlayerState.Idle);
    }

    public void Jump()
    {
        if (groundCheck)
        {
            rb.velocity = new Vector2(rb.velocity.x, playerJumpForce);
            groundCheck = false;
            animator.SetTrigger("Jump");
            SetNewState(PlayerState.Jump);
        }
    }
    
    public void Attack()
    {
        if (groundCheck)
        {
            StopMove();
            animator.SetTrigger("Attack");
            SetNewState(PlayerState.Attack);
        }
    }

    private void SetNewState(PlayerState newState)
    {
        GetState = currentState = newState;
    }
}