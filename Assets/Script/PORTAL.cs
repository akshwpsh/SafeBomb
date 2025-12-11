using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PORTAL : MonoBehaviour
{
    public bool portal;
    public bool portal1;
    public bool portal2;
    public bool portal3;
    public bool portal4;
    public bool portal5;
    public bool portal6;
    public bool portal7;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            if(portal1 == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL(Clone)").transform.position;
                GameObject.Find("PORTAL(Clone)").GetComponent<PORTAL>().portal = false;
            }
            if(portal == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL 1(Clone)").transform.position;
                GameObject.Find("PORTAL 1(Clone)").GetComponent<PORTAL>().portal1 = false;
            }
           
            if (portal3 == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL 2(Clone)").transform.position;
                GameObject.Find("PORTAL 2(Clone)").GetComponent<PORTAL>().portal2 = false;
            }
            if (portal2 == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL 3(Clone)").transform.position;
                GameObject.Find("PORTAL 3(Clone)").GetComponent<PORTAL>().portal3 = false;
            }
            
            if (portal5 == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL 4(Clone)").transform.position;
                GameObject.Find("PORTAL 4(Clone)").GetComponent<PORTAL>().portal4 = false;
            }
            if (portal4 == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL 5(Clone)").transform.position;
                GameObject.Find("PORTAL 5(Clone)").GetComponent<PORTAL>().portal5 = false;
            }
           
            if (portal7 == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL 6(Clone)").transform.position;
                GameObject.Find("PORTAL 6(Clone)").GetComponent<PORTAL>().portal6 = false;
            }
            if (portal6 == true)
            {
                collision.gameObject.transform.position = GameObject.Find("PORTAL 7(Clone)").transform.position;
                GameObject.Find("PORTAL 7(Clone)").GetComponent<PORTAL>().portal7 = false;
            }
            /*if(this.gameObject.tag == "PORTAL")
            {
                GameObject.FindWithTag("PORTAL").gameObject.tag = "PORTAL1";
                
            } */
            //collision.gameObject.transform.position = GameObject.FindWithTag("PORTAL1").transform.position;
            //collision.gameObject.transform.position = GameObject.Find("PORTAL 1(Clone)").transform.position;
        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Bomb")
        {
           if(this.gameObject.name == "PORTAL(Clone)")
            {
                portal = true;
            }
           if(this.gameObject.name == "PORTAL 1(Clone)")
            {
                portal1 = true;
            }

            if (this.gameObject.name == "PORTAL 2(Clone)")
            {
                portal2 = true;
            }
            if (this.gameObject.name == "PORTAL 3(Clone)")
            {
                portal3 = true;
            }

            if (this.gameObject.name == "PORTAL 4(Clone)")
            {
                portal4 = true;
            }
            if (this.gameObject.name == "PORTAL 5(Clone)")
            {
                portal5 = true;
            }

            if (this.gameObject.name == "PORTAL 6(Clone)")
            {
                portal6 = true;
            }
            if (this.gameObject.name == "PORTAL 7(Clone)")
            {
                portal7 = true;
            }
        }
    }

}


