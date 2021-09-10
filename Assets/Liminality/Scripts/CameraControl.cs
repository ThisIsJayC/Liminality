using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;

    // Camera offset, Z should always be -1 or else it wont show the sprite layers.
    public Vector3 offset = new Vector3(0,0.25f,-1);

    void LateUpdate()
    {
        transform.position = target.position + offset;
        //transform.position = new Vector3(transform.position.x, 0, 0);
    }
}
