using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int _sceneIndex;
    int _levelComplete;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
        _levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }

    public void IsEndGame()
    {
        if(_sceneIndex == 3)
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
        if (_levelComplete < _sceneIndex)
            PlayerPrefs.SetInt("LevelComplete", _sceneIndex);

        SceneManager.LoadScene(_sceneIndex + 1);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
