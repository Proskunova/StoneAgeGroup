using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public enum PlayerState
    {
        Idle,
        MoveLeft,
        MoveRighr,
        Jump,
        Attack
    }

    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        public static PlayerState GetState { get; private set; }

        [Header("Player")]
        [SerializeField] private float _playerSpeed = 200f;
        [SerializeField] private float _playerJumpForce = 7.2f;
        [SerializeField] private Animator _animator;
        [SerializeField] private PlayerState _currentState;

        Quaternion rotationLeft = Quaternion.Euler(new Vector3(0, 180, 0));
        Quaternion rotationRight = Quaternion.Euler(Vector3.zero);

        private float _currentPlayerSpeed;
        private Rigidbody2D _rb;

        public static bool GroundCheck;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            _rb.velocity = new Vector2(_currentPlayerSpeed * Time.deltaTime, _rb.velocity.y);
        }

        public void RightMove()
        {
            _currentPlayerSpeed = _playerSpeed;
            _animator.transform.rotation = rotationRight;
            _animator.SetBool("IsWalk", true);
            SetNewState(PlayerState.MoveRighr);
        }

        public void LeftMove()
        {
            _currentPlayerSpeed = -_playerSpeed;
            _animator.transform.rotation = rotationLeft;
            _animator.SetBool("IsWalk", true);
            SetNewState(PlayerState.MoveLeft);
        }

        public void StopMove()
        {
            _currentPlayerSpeed = 0f;
            _animator.SetBool("IsWalk", false);
            SetNewState(PlayerState.Idle);
        }

        public void Jump()
        {
            if (GroundCheck)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, _playerJumpForce);
                GroundCheck = false;
                _animator.SetTrigger("Jump");
                SetNewState(PlayerState.Jump);
            }
        }

        public void Attack()
        {
            if (GroundCheck)
            {
                StopMove();
                _animator.SetTrigger("Attack");
                SetNewState(PlayerState.Attack);
            }
        }

        private void SetNewState(PlayerState newState)
        {
            GetState = _currentState = newState;
        }
    }
}
