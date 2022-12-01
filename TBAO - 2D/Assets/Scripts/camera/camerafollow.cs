using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.9f;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("player").transform;
    }


    void FixedUpdate()
    {
        Vector3 startPosition = new Vector3(target.position.x, target.position.y, 1f);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, startPosition, smoothSpeed);
        transform.position = smoothPosition;

    }
}
