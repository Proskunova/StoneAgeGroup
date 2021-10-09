#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
   [SerializeField] private PlayerController _playerMove;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _playerMove.Jump();
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _playerMove.LeftMove();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            _playerMove.RightMove();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            _playerMove.StopMove();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerMove.Attack();
        }
        
    }
}
#endif