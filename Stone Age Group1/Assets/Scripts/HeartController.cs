using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartController : MonoBehaviour
{
    [SerializeField] private Image _heart;
    [Header("Full")]
    [SerializeField] private Sprite _spriteFull;
    [SerializeField] private Color _colorFull;
    [Header("Empty")]
    [SerializeField] private Sprite _spriteEmpty;
    [SerializeField] private Color _colorEmpty;

    private void Awake()
    {
        if (_heart == null) throw new UnityException("_heart == null");
    }

    public void SetFull()
    {
        _heart.sprite = _spriteFull;
        _heart.color = _colorFull;
    }

    public void SetEmpty()
    {
        _heart.sprite = _spriteEmpty;
        _heart.color = _colorEmpty;

    }








}
