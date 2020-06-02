using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlarformMoveR3 : MonoBehaviour
{
    public Animator _animatorMR;
    public Light2D _light;
    public BoxCollider2D _BoxCol;
    private Vector3 _startPos;
    private void Awake()
    {
        _startPos = transform.position;
    }

    //void start()
    //{
    //    _animation = GetComponent<Animator>();
    //}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            _animatorMR.enabled = true;
            _light.enabled = true;
            //_BoxCol.enabled = true;
        }
    }

    public void ResetPosition2()
    {
        transform.position = _startPos;
    }
}