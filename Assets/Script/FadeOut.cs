using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public GameObject black;
    public Image fade;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayFadeOut()
    {
        black.SetActive(true);
        StartCoroutine("PlayFadeout");
    }

    IEnumerator PlayFadeout()
    {
        Color color = fade.color;
        time = 0f;
        color.a = Mathf.Lerp(0, 1, time);

        while (color.a < 1f)
        {
            time += Time.deltaTime / 1f;

            color.a = Mathf.Lerp(0, 1, time);
            fade.color = color;

            yield return null;
        }
    }
}
