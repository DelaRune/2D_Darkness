using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    //public GameObject Dude_Pers;
    //private void OnTriggerEnter(Collider other)
    //{
    //  if (other.gameObject == Dude_Pers)
    //    {
    //    Dude_Pers.transform.parent = transform;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject == Dude_Pers)
    //    {
    //        Dude_Pers.transform.parent = null;
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //transform.parent = col.gameObject.transform;
            col.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //transform.parent = null;
            col.transform.parent = null;
        }
    }

}
