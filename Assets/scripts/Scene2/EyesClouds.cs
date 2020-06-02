using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesClouds : MonoBehaviour
{
    public Transform Pupil;
    public Transform Player;
    public Transform Eyeball;
    public float EyeRadius = 1f;

    void Update()
    {
        Vector3 lookOffset = (Player.position - Eyeball.position);
        if (lookOffset.magnitude > EyeRadius)
            lookOffset = lookOffset.normalized * EyeRadius;
        lookOffset.Scale(new Vector3(0.5f, 1.0f));
        Pupil.position = Eyeball.position + lookOffset;
    }
}
