using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int sceneIndex;
    int levelComplete;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }

    public void IsEndGame()
    {
        if(sceneIndex == 3)
        {
            Invoke("LoadMainMenu", 1f);
        }
        else
        {
            Invoke("Nextlevel", 1f);  
        }
    }

    void Nextlevel()
    {
        if (levelComplete < sceneIndex)
            PlayerPrefs.SetInt("LevelComplete", sceneIndex);

        SceneManager.LoadScene(sceneIndex + 1);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
