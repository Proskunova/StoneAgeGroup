using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum FruitsType
{
    Apple = 0,
    Peach = 1,
    Orange = 2,
}

[RequireComponent(typeof(Button))]
public class ButtonFruit : MonoBehaviour
{
    public static event Action<FruitsType> OnClickFruit;

    [SerializeField] private FruitsType _fruitsT;
    [SerializeField] private Button _button;
    [SerializeField] private Image _image;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ClickFruit);
    }

    private void ClickFruit()
    {
        OnClickFruit?.Invoke(_fruitsT);
        _image.gameObject.SetActive(true);
    }
}
