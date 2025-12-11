using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TEXTEFFECT : MonoBehaviour
{
    Text blink;
    public float time;

    void Start()
    {
        blink = GetComponent<Text>();
        StartCoroutine(BlinkText());

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


    public IEnumerator BlinkText()
    {
        while (true)
        {
            blink.text = "";
            yield return new WaitForSeconds(time);
            blink.text = "- TOUCH TO CONTINUE -";
            yield return new WaitForSeconds(time);
        }
    }
}
