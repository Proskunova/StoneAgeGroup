using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class TriggerZoneController : MonoBehaviour
    {
        [SerializeField] private Transform _startPoint;
        [SerializeField] private Indicators _indicators;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag != "Player") return;

            collision.transform.position = _startPoint.position;
            _indicators.LifePlayer();
        }
    }
}

