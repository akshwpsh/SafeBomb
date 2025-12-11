using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WALL : MonoBehaviour
{

    public Sprite[] walls;


    private void Start()
    {
        if (Scene.c_num == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = walls[0];
        }
        if (Scene.c_num == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = walls[1];
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       /*if(collision.tag == "SEMO")
        {
            if(collision.gameObject.GetComponent<SEMO>().isbomb == true)
            {
                Debug.Log("isbomb 가 정말이래");
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<SEMO>().isbomb == true)
        {
            Destroy(this.gameObject);
        }*/
    }
}
