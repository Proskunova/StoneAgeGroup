using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneController : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    [SerializeField] private Indicators indicators;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player") return;

        collision.transform.position = startPoint.position;
        indicators.LifePlayer();
    }
}
