using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private Vector3 _vector3;

        private void Update()
        {
            transform.Rotate(_vector3 * Time.deltaTime);
        }
    }
}

