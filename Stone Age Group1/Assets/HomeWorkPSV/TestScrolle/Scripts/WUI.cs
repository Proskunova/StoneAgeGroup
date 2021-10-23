using UnityEngine;
using UnityEngine.UI;

public class WUI : MonoBehaviour
{
    [SerializeField] private Text _text;


    private void OnEnable()
    {
        ButtonWeapon.OnClickWeapon += SetNameWeapon;
    }

    private void OnDisable()
    {
        ButtonWeapon.OnClickWeapon -= SetNameWeapon;
    }

    private void SetNameWeapon(WeaponsType weaponsType)
    {
        switch (weaponsType)
        {
            case WeaponsType.Axe:
                _text.text = "Axe";
                break;
            case WeaponsType.Club:
                _text.text = "Club";
                break;
            case WeaponsType.Hammer:
                _text.text = "Hammer";
                break;
            
        }
    }
}
