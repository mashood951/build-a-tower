using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnContainer : MonoBehaviour
{
    public GameObject container;
    public List<GameObject> containers;
    private Vector3 previousPosition;
    private Quaternion previousRotation;

    void Start()
    {
        containers.Add(Instantiate(container, transform.position, transform.rotation));
    }

    void FixedUpdate()
    {
        GameObject currentContainer = containers[containers.Count - 1];
        Vector3 currentPosition = currentContainer.transform.position;
        Quaternion currentRotation = currentContainer.transform.rotation;

        // checking if current container is landed
        if (previousPosition == currentPosition && previousRotation == currentRotation)
        {
            containers.Add(Instantiate(container, transform.position, transform.rotation));
            currentContainer = containers[containers.Count - 1];
            previousPosition = currentContainer.transform.position;
            previousRotation = currentContainer.transform.rotation;
        }
        else
        {
            previousPosition = currentPosition;
            previousRotation = currentRotation;
        }
    }
}































// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SpawnContainer : MonoBehaviour
// {
//     public GameObject container;
//     public List<GameObject> containers;
//     private Vector3 previousPosition;
//     private Quaternion previousRotation;

//     void Start()
//     {
//         containers.Add(Instantiate(container, transform.position, transform.rotation));
//     }

//     void FixedUpdate()
//     {
//         GameObject currentContainer = containers[containers.Count - 1];
//         Vector3 currentPosition = currentContainer.transform.position;
//         Quaternion currentRotation = currentContainer.transform.rotation;

//         if (previousPosition == currentPosition && previousRotation == currentRotation)
//         {
//             containers.Add(Instantiate(container, transform.position, transform.rotation));
//             currentContainer = containers[containers.Count - 1];
//             previousPosition = currentContainer.transform.position;
//             previousRotation = currentContainer.transform.rotation;
//         }
//         else
//         {
//             previousPosition = currentPosition;
//             previousRotation = currentRotation;
//         }
//     }
// }