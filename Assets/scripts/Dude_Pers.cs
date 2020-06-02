
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dude_Pers : MonoBehaviour
{
   
    public float jumpForce;
    private float extraJumps;
    public int JumpsAll;
    public float speed = 20f;
    private Rigidbody2D rb;
    private bool faceRight = true;
    private bool isGrounded;
    public Transform GroundCheck;
    public float checkRadius;
    public LayerMask WhatIsGround;
    private float move;
    public Animator _animator;
    public UnityEvent prost;
    private Vector3 _startPos;
    private bool Is_dead = false;
    public bool isMoving = false;
    public AudioSource steps;

    public bool IsDead
    {
        get { return Is_dead; }
        set { Is_dead = value; }
    }

    private void Awake()
    {
        _startPos = transform.position;
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
        
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position,checkRadius, WhatIsGround);

        
        rb.velocity = new Vector2(move * speed, rb.velocity.y);


        if (move > 0 && !faceRight)
            flip();
        else if (move < 0 && faceRight)
            flip();

    }

    private void Update()
    {
        _animator.SetFloat("speed", Mathf.Abs(move*1.7f));
        move = Input.GetAxis("Horizontal");

        if (isGrounded == true)
        {
            extraJumps = JumpsAll;
        }
        else { steps.Stop(); }
        if (rb.velocity.x != 0)
        {
            isMoving = true;
        }
        else isMoving = false;
        if (isMoving)
        {
            if (!steps.isPlaying) steps.Play();
        }
        else steps.Stop();
        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            _animator.SetTrigger("jump");
            //_animator.SetBool("jump", true);
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }

        else if (Input.GetKeyDown(key: KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            _animator.SetTrigger("jump");
        }
    }

    //    public void OnLanding()
    //{
    //    _animator.SetBool("jump", false);
    //}

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    public void ResetPosition()
    {
        transform.position = _startPos;   
    }
}