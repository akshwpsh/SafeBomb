using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] 튜토리얼;
    public int ispage = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        if (ispage == 4)
        {
            SceneManager.LoadScene("CHAPTER");

        }
        if (ispage == 3)
        {
            튜토리얼[3].SetActive(false);
            튜토리얼[4].SetActive(true);
            ispage++;
        }
        if (ispage == 2)
        {
            튜토리얼[2].SetActive(false);
            튜토리얼[3].SetActive(true);
            ispage++;
        }
        if (ispage == 1)
        {
            튜토리얼[1].SetActive(false);
            튜토리얼[2].SetActive(true);
            ispage++;
        }
        if (ispage == 0)
        {
            튜토리얼[0].SetActive(false);
            튜토리얼[1].SetActive(true);
            ispage++;
        }
        
      
      
       


    }
}
