using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;


public class ToggleGameobject : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject obj;

    public void OnPointerClick(PointerEventData eventData)
    {
        obj.SetActive(!obj.activeInHierarchy);
    }
}
