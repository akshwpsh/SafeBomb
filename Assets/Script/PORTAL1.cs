using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PORTAL1 : MonoBehaviour
{
    public bool portal;
    public bool portal1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            collision.gameObject.transform.position = GameObject.FindWithTag("PORTAL").transform.position;
            //collision.gameObject.transform.position = GameObject.Find("PORTAL 1(Clone)").transform.position;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (this.gameObject.tag == "PORTAL")
        {
            if (collision.tag == "Bomb")
            {
                this.gameObject.tag = "PORTAL1";
                GameObject.FindWithTag("PORTAL1").gameObject.tag = "PORTAL";
            }
        }
    }

}


