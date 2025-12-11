using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ED_EDITOR : MonoBehaviour
{
    public static GameObject click_obj;
    public GameObject test;
    public static Vector3 witch;
    public Vector3 withthth;

    private void Awake()
    {
        witch.x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        withthth = witch;
        test = click_obj;
    }
}
