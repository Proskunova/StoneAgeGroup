using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SO/FoodData")]
public class FoodDataSO : ScriptableObject
{
  [System.Serializable]

  public class FoodData
    {
        public FoodType foodType;
        public int amount;

    }

    public List<FoodData> foodDatas;




}
