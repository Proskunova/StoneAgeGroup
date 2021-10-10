using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public enum FoodType
    {
        Superbanana = 8,
        Banana = 0,
        Orange = 1,
        Coconut = 2,
        Mushroom = 3,
        Pineapple = 4,
        Grape = 5,
        Lemon = 6,
        Cherry = 7
    }

    public class Indicators : MonoBehaviour
    {
        [SerializeField] HeartController _heartController;
        [SerializeField] Transform _startPoint;
        [SerializeField] GameObject _player;
        [SerializeField] GameOver _gameOver;

        private int _maxFoodAmount = 100;

        public Image FoodBar;
        public float FoodAmount;
        public float SecondsToEmptyFood;

        void Start()
        {
            FoodBar.fillAmount = FoodAmount / _maxFoodAmount;
        }

        void Update()
        {
            if (FoodAmount > 0)
            {
                FoodAmount -= _maxFoodAmount / SecondsToEmptyFood * Time.deltaTime;
                FoodBar.fillAmount = FoodAmount / _maxFoodAmount;
            }
            if (FoodAmount <= 0)
            {
                FoodAmount = _maxFoodAmount;
                LifePlayer();
                _player.transform.position = _startPoint.position;
            }
        }

        public void LifePlayer()
        {
            print("LifePlayer");
            int countHearts = PlayerPrefs.GetInt("PlayerLives", _heartController.heartImages.Count);
            Debug.Log(countHearts);

            countHearts--;

            PlayerPrefs.SetInt("PlayerLives", countHearts);

            if (countHearts <= 0)
            {
                _gameOver.GameOverScreen();
                return;
            }

            _heartController.ChangeHeart();
        }

        public void ChangeAmount(int v)
        {
            FoodAmount += v;
            if (FoodAmount > _maxFoodAmount) FoodAmount = _maxFoodAmount;
        }
    }
}


