using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public int _score;
    public Text _textScore;

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
