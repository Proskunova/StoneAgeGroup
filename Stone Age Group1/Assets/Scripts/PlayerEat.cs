using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEat : MonoBehaviour
{
    [SerializeField] Indicators indicator;
    [SerializeField] FoodDataSO data;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Eat(FoodType foodType)
    {
        int amount = 0;
        foreach (var item in data.foodDatas)
        {
            if(item.foodType == foodType)
            {
                amount = item.amount;
                break;
            }
        }

        audioSource.Play();

        indicator.ChangeAmount(amount);

    }

}
