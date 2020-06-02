using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Clouds : MonoBehaviour
{
    public Animator Lithning;
    private RaycastHit2D hit;
    public Dude_Pers pers;
    private Dude_Pers ScriptDude;
    private Rigidbody2D FreezDude;
    public AudioSource lithning;
    public GameObject lithnings1;


    //private void Awake()
    //{
    //    Lithning = GetComponent<Animator>();
    //}

    private void Awake()
    {
        ScriptDude = GameObject.Find("Dude_Pers").GetComponent<Dude_Pers>();
        FreezDude = GameObject.Find("Dude_Pers").GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Направить луч прямо вниз.
        hit = Physics2D.Raycast(transform.position, -Vector2.up);

        // Если что-то ударит ...
        if (hit.transform.CompareTag("Player") && !ScriptDude.IsDead)
        {
            //Lithning.SetTrigger("Hit");
            lithning.Play();
            lithnings1.SetActive(true);
       
            Lithning.SetBool("hit", true);        
            ScriptDude.IsDead = true;
            //lithning.enabled = true;
            StartCoroutine("CoroutineDead");
        }
    }

        private IEnumerator CoroutineDead()
        {
            FreezDude.constraints = RigidbodyConstraints2D.FreezeAll;
            yield return new WaitForSeconds(0.26f);
       
            ScriptDude.ResetPosition();
            FreezDude.constraints = RigidbodyConstraints2D.None;
            FreezDude.constraints = RigidbodyConstraints2D.FreezeRotation;
            Lithning.SetBool("hit", false);
            ScriptDude.IsDead = false;
          yield return new WaitForSeconds(2f);
        //lithning.enabled = true;


    }
        


}
