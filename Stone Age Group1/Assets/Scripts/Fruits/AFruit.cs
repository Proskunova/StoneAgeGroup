using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class AFruit : MonoBehaviour
    {
        public int FoodAmount => foodAmount;

        [SerializeField] protected int points;
        [SerializeField] protected int foodAmount;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerEat>().Eat(this);
                gameObject.SetActive(false);
            }
        }

        public abstract int GetPoints();
        

    }

}

