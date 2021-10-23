using System;
using UnityEngine;
using UnityEngine.UI;

public enum WeaponsType
{
    Axe = 0,
    Club = 1,
    Hammer = 2,
}
[RequireComponent(typeof(Button))]

public class ButtonWeapon : MonoBehaviour
{
    public static event Action<WeaponsType> OnClickWeapon;

    [SerializeField] private WeaponsType _weaponT;
    [SerializeField] private Button _button;

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
        OnClickWeapon?.Invoke(_weaponT);
    }





}
