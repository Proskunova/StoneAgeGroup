using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button level2B;
    [SerializeField] Button level3B;

    int levelComplete;


    private void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete", 0);

        level2B.gameObject.SetActive(false);
        level3B.gameObject.SetActive(false);
        level2B.transform.parent.gameObject.SetActive(false);

        switch(levelComplete)
        {
            case 1:
                level2B.gameObject.SetActive(true);
                break;

            case 2:
                level2B.gameObject.SetActive(true);
                level3B.gameObject.SetActive(true);
                break;

            default:
                break;
        }
    }
    public void LoadTo (int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();

        LoadTo(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Debug.Log("exit game by button");

        Application.Quit();
    }
}

