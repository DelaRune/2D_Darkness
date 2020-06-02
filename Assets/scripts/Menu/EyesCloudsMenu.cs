using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesCloudsMenu : MonoBehaviour
{
    public Transform Pupil;
    public Transform Eyeball;
    public float EyeRadius = 1f;
    public Camera cam;
    public Vector3 newpos;
    private Event _currentEvent;

    private void Start()
    {
        cam = Camera.main;
        _currentEvent = Event.current;
    }

    void Update()
    {
        newpos = cam.ScreenToWorldPoint(new Vector3(_currentEvent.mousePosition.x, _currentEvent.mousePosition.y));
        
        Vector3 lookOffset = (newpos - Eyeball.position);
        if (lookOffset.magnitude > EyeRadius)
            lookOffset = lookOffset.normalized * EyeRadius;
        lookOffset.Scale(new Vector3(0.5f, 1.0f));
        Pupil.position = Eyeball.position + lookOffset;
    }


}