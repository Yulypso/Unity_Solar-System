using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This complete script can be attached to a Info to make it
// continuously point at another object.

public class LookAtCamera : MonoBehaviour
{
    private Camera _camera = null;

    private void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        transform.LookAt(_camera.transform.position);
    }
}