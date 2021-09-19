using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartController : MonoBehaviour
{
    public List<Image> heartImages;

    [Header("Full")]
    [SerializeField] private Sprite _spriteFull;
    [SerializeField] private Color _colorFull;
    [Header("Empty")]
    [SerializeField] private Sprite _spriteEmpty;
    [SerializeField] private Color _colorEmpty;

    private void Awake()
    {
        ChangeHeart();
    }

    private void SetFull(Image img)
    {
        img.sprite = _spriteFull;
        img.color = _colorFull;
    }

    private void SetEmpty(Image img)
    {
        img.sprite = _spriteEmpty;
        img.color = _colorEmpty;
    }

    public void ChangeHeart()
    {
        int countHearts = PlayerPrefs.GetInt("PlayerLives", heartImages.Count);

        if(countHearts <= 0 || countHearts > heartImages.Count)
        {
            Debug.Log("START NEW GAME");

            countHearts = heartImages.Count;
        }

        for (int i = 0; i < heartImages.Count;  i++)
        {
            if( i < countHearts)
            {
                SetFull(heartImages[i]);
            }
            else
            {
                SetEmpty(heartImages[i]);
            }
        }
    }
}
