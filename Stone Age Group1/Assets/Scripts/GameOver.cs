﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void GameOverScreen()
    {
        print("GameOverScreen");

        gameObject.SetActive(true);
    }

    public void TryAgainButton()
    {
        PlayerPrefs.DeleteKey("PlayerLives");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
