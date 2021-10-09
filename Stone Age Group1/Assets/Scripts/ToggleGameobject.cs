using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;


public class ToggleGameobject : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject _obj;

    public void OnPointerClick(PointerEventData eventData)
    {
        _obj.SetActive(!_obj.activeInHierarchy);
    }
}
