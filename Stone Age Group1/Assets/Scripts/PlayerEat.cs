using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Game
{
    public class PlayerEat : MonoBehaviour
    {
        public static event Action<int> OnEat;

        [SerializeField] Indicators _indicator;
        [SerializeField] FoodDataSO _data;

        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void Eat(FoodType FoodTypes)
        {
            int amount = 0;
            foreach (var item in _data.foodDatas)
            {
                if (item.FoodTypes == FoodTypes)
                {
                    amount = item.Amount;
                    break;
                }
            }

            OnEat?.Invoke(1);

            _audioSource.Play();

            _indicator.ChangeAmount(amount);
        }

        public void Eat(AFruit fruit)
        {
            int scorePoints = fruit.GetPoints();
            
            OnEat?.Invoke(scorePoints);

            _audioSource.Play();

            _indicator.ChangeAmount(fruit.FoodAmount);
        }
    }
}


