using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsLandedContainer : MonoBehaviour
{
    private Vector3 previousPosition;
    private Quaternion previousRotation;
    public static bool isLanded;
    
    void Start()
    {
        isLanded = false;
    }

    void FixedUpdate()
    {
        Debug.Log(transform.position);
        Vector3 currentPosition = transform.position;
        Quaternion currentRotation = transform.rotation;

        if (previousPosition == currentPosition && previousRotation == currentRotation)
        {
            Debug.Log("done");
            isLanded = true;
        }

        previousPosition = currentPosition;
        previousRotation = currentRotation;
    }
}
