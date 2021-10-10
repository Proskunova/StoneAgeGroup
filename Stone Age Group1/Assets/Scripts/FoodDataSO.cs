using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "Data", menuName = "SO/FoodData")]
    public class FoodDataSO : ScriptableObject
    {
        [System.Serializable]

        public class FoodData
        {
            public FoodType FoodTypes;
            public int Amount;
        }

        public List<FoodData> foodDatas;
    }
}


