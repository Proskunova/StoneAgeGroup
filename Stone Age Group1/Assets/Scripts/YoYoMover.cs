using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoYoMover : MonoBehaviour
{
    [SerializeField] private List<Transform> listPoints;
    [SerializeField] private float speed;
    [SerializeField] private Transform moveTarget;
    [SerializeField] private float distanceDelta;
    [SerializeField] private int curentIndex;

    private void Awake()
    {
        curentIndex = 0;
        moveTarget = GetNextPoint();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveTarget.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, moveTarget.position) < distanceDelta) moveTarget = GetNextPoint();
        
    }

    private Transform  GetNextPoint()
    {
        Transform temp = listPoints[curentIndex];
        curentIndex++;
        if (curentIndex >= listPoints.Count) curentIndex = 0;
        return temp;
    }

}
