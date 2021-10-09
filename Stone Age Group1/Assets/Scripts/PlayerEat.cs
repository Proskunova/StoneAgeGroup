using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerEat : MonoBehaviour
{
    public static event Action OnEat;

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
            if(item.FoodTypes == FoodTypes)
            {
                amount = item.Amount;
                break;
            }
        }

        OnEat?.Invoke();

        _audioSource.Play();

        _indicator.ChangeAmount(amount);
    }
}
