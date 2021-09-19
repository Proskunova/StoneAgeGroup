using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 vector3;
    private void Update()
    {
        transform.Rotate(vector3 * Time.deltaTime);
    }
}
