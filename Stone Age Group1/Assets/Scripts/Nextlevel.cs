﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelController.instance.IsEndGame();
    }


}
