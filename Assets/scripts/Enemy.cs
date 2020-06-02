using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Rendering.Universal;

public class Enemy : MonoBehaviour
{
    public Animator _an1;
    public Animator _an2;
    public Animator _an3;
    public Dude_Pers pers;
    public Light2D _light1;
    public Light2D _light2;
    public Light2D _light3;
    public PlatformMoveR2 _respos1;
    public PlarformMoveR3 _respos2;
    public platMoveR _respos3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
          
            pers.ResetPosition();
            
            //SceneManager.LoadScene("SampleScene");
            _an1.enabled = false;
            _an1.Play("", 0, 0f);
            _an2.enabled = false;
            _an2.Play("", 0, 0f);
            _an3.enabled = false;
            _an3.Play("", 0, 0f);
            _light1.enabled = false;
            _light2.enabled = false;
            _light3.enabled = false;
            _respos1.ResetPosition1();
            _respos2.ResetPosition2();
            _respos3.ResetPosition3();


        }
    }
    
}

