using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_move : MonoBehaviour
{
    public GameObject bomb;


    void Start()
    {
        
    }

   
    void Update()
    {
        move();
    }


    void move()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            bomb.transform.Translate(0, -1, 0);
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            bomb.transform.Translate(0, 1, 0);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            bomb.transform.Translate(-1, 0, 0);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            bomb.transform.Translate(1, 0, 0);
        }
    }
}
