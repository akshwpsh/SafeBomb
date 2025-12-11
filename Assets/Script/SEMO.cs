using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEMO : MonoBehaviour
{
    //public bool isbomb = false;
    ///public static bool is_bomb = false;
    public bool up;
    public bool down;
    public bool left;
    public bool right;

    public GameObject bullet;

    public Sprite[] semos;

    private Vector3 ins;

    private void Awake()
    {
        ins = this.gameObject.transform.position;
        //isbomb = false;
        //is_bomb = false;
        //this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void Start()
    {
         if(Scene.c_num == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = semos[0];
        }
         if(Scene.c_num == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = semos[1];
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       /* if (collision.tag == "Bomb")
        {
            isbomb = true;
            Debug.Log("폭탄");

        }
        if(isbomb == true)
        {
            Debug.Log("is_bomb가 켜졌네");
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            if (collision.tag == "WALL")
            {
                Debug.Log("벽에 닿았다");
                
            }
        }*/

        if(collision.tag == "Bomb")
        {
            if (up == true)
            {
                Instantiate(bullet, new Vector3(ins.x, ins.y + 0.6f, ins.z), Quaternion.identity);
            }
            else if (down == true)
            {
                Instantiate(bullet, new Vector3(ins.x, ins.y - 0.6f, ins.z), Quaternion.identity);
            }
            else if (left == true)
            {
                Instantiate(bullet, new Vector3(ins.x - 0.6f, ins.y, ins.z), Quaternion.identity);
            }
            else if (right == true)
            {
                Instantiate(bullet, new Vector3(ins.x + 0.6f, ins.y, ins.z), Quaternion.identity);
            }
        }


    }


}
