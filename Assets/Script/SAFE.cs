using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAFE : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            naman.re_bomb -= 1;
            //Debug.Log(naman.re_bomb);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            naman.re_bomb += 1;
            //Debug.Log(naman.re_bomb);
        }
    }
}
