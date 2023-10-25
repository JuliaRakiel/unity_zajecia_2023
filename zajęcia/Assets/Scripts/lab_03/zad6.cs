using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad6 : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public float smoothTime = 0.3F;
    private Vector3 velocity1 = Vector3.zero;
    private Vector3 velocity2 = Vector3.zero;

    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition1 = target1.TransformPoint(new Vector3(0, 5, -10));
        Vector3 targetPosition2 = target2.TransformPoint(new Vector3(0, 5, -10));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition1, ref velocity1, smoothTime);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition2, ref velocity2, smoothTime);
    }
}