using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class safe : MonoBehaviour
{
    float distance = 10.0f;


    void Start()
    {
        
    }

    void OnMouseDrag()
    {
        print("Drag!!");
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;



        /*float xMove = Input.mousePosition.x * speed * Time.deltaTime;

        float yMove = Input.mousePosition.y * speed * Time.deltaTime;

        transform.Translate(new Vector3(xMove, yMove, dis));*/
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
       
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bomb")
        {
            Debug.Log("SAFE BOMB~!!");
        }

    }

    



}
