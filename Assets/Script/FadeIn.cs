using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FadeIn : MonoBehaviour
{
    public GameObject black;
    public Image fade;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("offblack", 1f);
        StartCoroutine("PlayFadeIn");
    }
    void offblack()
    {
        black.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator PlayFadeIn()
    {
        Color color = fade.color;
        time = 0f;
        color.a = Mathf.Lerp(1, 0, time);

        while(color.a>0f)
        {
            time += Time.deltaTime / 1f;

            color.a = Mathf.Lerp(1, 0, time);
            fade.color = color;

            yield return null;
        }
        
    }
}
