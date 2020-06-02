using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlatformMoveR2 : MonoBehaviour
{
    public Animator _animatorMR;
    public Light2D _light;
    public BoxCollider2D _BoxCol;
    private Vector3 _startPos;


    //void start()
    //{
    //    _animation = GetComponent<Animator>();
    //}
    private void Awake()
    {
        _startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            _animatorMR.enabled = true;
            _light.enabled = true;
            //_BoxCol.enabled = true;
        }
    }
    public void ResetPosition1()
    {
        transform.position = _startPos;
    }
}