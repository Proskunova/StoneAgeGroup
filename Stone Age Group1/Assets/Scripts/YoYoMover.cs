using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class YoYoMover : MonoBehaviour
    {
        [SerializeField] private List<Transform> _listPoints;
        [SerializeField] private float _speed;
        [SerializeField] private Transform _moveTarget;
        [SerializeField] private float _distanceDelta;
        [SerializeField] private int _curentIndex;

        private void Awake()
        {
            _curentIndex = 0;
            _moveTarget = GetNextPoint();
        }

        private void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, _moveTarget.position, _speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, _moveTarget.position) < _distanceDelta) _moveTarget = GetNextPoint();
        }

        private Transform GetNextPoint()
        {
            Transform temp = _listPoints[_curentIndex];
            _curentIndex++;
            if (_curentIndex >= _listPoints.Count) _curentIndex = 0;
            return temp;
        }
    }
}

