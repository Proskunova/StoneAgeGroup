using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicators : MonoBehaviour
{
    public Image foodBar;
    public float foodAmount = 100f;
    public float secondsToEmptyFood;

    
    void Start()
    {
        foodBar.fillAmount = foodAmount / 100;
    }

    void Update()
    {
        if(foodAmount > 0)
        {
            foodAmount -= 100 / secondsToEmptyFood * Time.deltaTime;
            foodBar.fillAmount = foodAmount / 100;
        }
    }

        
    

}
