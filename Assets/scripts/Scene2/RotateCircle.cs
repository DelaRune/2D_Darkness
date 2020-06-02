using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public float speed = 10;
    public Vector3 Rotater;
    
    void Update()
    {
        transform.Rotate(Vector2.up * speed * Time.deltaTime, Space.Self);
    }
}
