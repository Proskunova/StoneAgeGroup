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

        private void OnEnable()
        {
            PlayerEat.OnEat += ScoreCounts;
        }

        private void OnDisable()
        {
            PlayerEat.OnEat -= ScoreCounts;
        }

        private void ScoreCounts()
        {
            _score++;
            _textScore.text = _score.ToString();
            Debug.Log(_score);
        }
    }
}


