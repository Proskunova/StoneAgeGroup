using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button _level2B;
    [SerializeField] Button _level3B;

    int _levelComplete;

    private void Start()
    {
        _levelComplete = PlayerPrefs.GetInt("LevelComplete", 0);

        _level2B.gameObject.SetActive(false);
        _level3B.gameObject.SetActive(false);
        _level2B.transform.parent.gameObject.SetActive(false);

        switch(_levelComplete)
        {
            case 1:
                _level2B.gameObject.SetActive(true);
                break;

            case 2:
                _level2B.gameObject.SetActive(true);
                _level3B.gameObject.SetActive(true);
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

