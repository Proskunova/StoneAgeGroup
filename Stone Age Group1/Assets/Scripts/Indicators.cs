using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Image foodBar;
    public float foodAmount;
    public float secondsToEmptyFood;

    private int maxFoodAmount = 100;

    [SerializeField] HeartController heartController;
    [SerializeField] Transform startPoint;
    [SerializeField] GameObject player;
    [SerializeField] GameOver gameOver;
    
    void Start()
    {
        foodBar.fillAmount = foodAmount / maxFoodAmount;
    }

    void Update()
    {
        if(foodAmount > 0)
        {
            foodAmount -= maxFoodAmount / secondsToEmptyFood * Time.deltaTime;
            foodBar.fillAmount = foodAmount / maxFoodAmount;
        }
        if(foodAmount <= 0)
        {
            foodAmount = maxFoodAmount;
            LifePlayer();
            player.transform.position = startPoint.position;

        }
    }

    public void LifePlayer()
    {
        print("LifePlayer");
        int countHearts = PlayerPrefs.GetInt("PlayerLives", heartController.heartImages.Count);
        Debug.Log(countHearts);

        countHearts--;

        PlayerPrefs.SetInt("PlayerLives", countHearts);

        if (countHearts <= 0)
        {
            gameOver.GameOverScreen();
            return;
        }

        heartController.ChangeHeart();

    }
    public void ChangeAmount(int v)
    {
        foodAmount += v;
        if (foodAmount > maxFoodAmount) foodAmount = maxFoodAmount;
    }

}
