#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
   [SerializeField] private PlayerController playerMove;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerMove.Jump();
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerMove.LeftMove();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerMove.RightMove();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerMove.StopMove();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerMove.Attack();
        }
        
    }
}
#endif