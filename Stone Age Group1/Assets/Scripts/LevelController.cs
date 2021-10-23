using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game
{
    public class LevelController : MonoBehaviour
    {
        public static LevelController instance = null;

        [SerializeField] private Image _image;

        int _sceneIndex;
        int _levelComplete;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            _sceneIndex = SceneManager.GetActiveScene().buildIndex;
            _levelComplete = PlayerPrefs.GetInt("LevelComplete");
        }

        public void Start()
        {
            _image.DOFade(1, 0f);
            _image.DOFade(0, 3f).SetEase(Ease.Linear).SetUpdate(true).OnComplete(delegate
            {
                Time.timeScale = 1;
            });
            Time.timeScale = 0;
        }

        private void OnDisable()
        {
            _image.DOKill();
        }

    public void IsEndGame()
        {
            if (_sceneIndex == 3)
            {
                Invoke("LoadMainMenu", 1f);
            }
            else
            {
                Invoke("Nextlevel", 1f);
            }
        }

         public void Nextlevel()
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
}

