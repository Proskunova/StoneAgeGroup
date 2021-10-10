using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class ScoreCount : MonoBehaviour
    {
        [SerializeField] private int _score;
        [SerializeField] private Text _textScore;

        private void Start()
        {
            _score = 0;
            UpdateText();
        }

        private void OnEnable()
        {
            PlayerEat.OnEat += ScoreCounts;
        }

        private void OnDisable()
        {
            PlayerEat.OnEat -= ScoreCounts;
        }

        private void ScoreCounts(int points)
        {
            _score += points;
            UpdateText();
            Debug.Log(_score);
        }

        private void UpdateText()
        {
            _textScore.text = _score.ToString();

        }
    }
}



