using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class naman : MonoBehaviour
{
    public static bool istouch;
    public static int jok;
    public static int re_bomb;

    public Text remain_b;

    public GameObject end;
    public GameObject[] blanks;
    public GameObject pause;
    public GameObject B_BGM;
    public GameObject back;
    public GameObject next;
    public static GameObject bombs;

    public Sprite n_bomb;
    public Sprite B_BGM_OFF;
    public Sprite B_BGM_ON;
    public Sprite[] background; //배경

    public bool bgm;


    private void Awake()
    {

        Time.timeScale = 1;
        //this.gameObject.GetComponent<AudioSource>().Play();
        re_bomb = 2;
        bombs = null;
        istouch = false;
        if(BLOCKM.ixe <= 1)
        {   // 14
            Instantiate(blanks[0], new Vector3(0.02f, 0.37f, -5), Quaternion.identity);
        }
        else if(BLOCKM.ixe <=5)
        {   //44
            Instantiate(blanks[1], new Vector3(0, -1, -5), Quaternion.identity);
        }
        else if(BLOCKM.ixe <=8)
        {   //55
            Instantiate(blanks[2], new Vector3(0, -0.5f, -5), Quaternion.identity);
        }
        else if (BLOCKM.ixe <= 11)
        {   //66
            Instantiate(blanks[3], new Vector3(0, -0.5f, -5), Quaternion.identity);
        }
        else if(BLOCKM.ixe <= 16)
        {
            Instantiate(blanks[1], new Vector3(0, -1, -5), Quaternion.identity);
        }
        else if (BLOCKM.ixe <= 20)
        {   //55
            Instantiate(blanks[2], new Vector3(0, -0.5f, -5), Quaternion.identity);
        }
        else if (BLOCKM.ixe <= 24)
        {   //66
            Instantiate(blanks[3], new Vector3(0, -0.5f, -5), Quaternion.identity);
        }

    }
    private void Start()
    {
        pause.SetActive(false);
        
    }
    private void Update()
    {
        Change_backgorund(Scene.chpter_num);

        //Debug.Log(bombs);
        if (bombs == null)
        {
            istouch = false;
            //Debug.Log("없음");
        }
        else
        {
            istouch = true;
            //Debug.Log("있음");
        }
        //Debug.Log(re_bomb);
        if(re_bomb == 0 && end.activeSelf == false)
        {
            end.SetActive(true);

            if(BLOCKM.ixe == 11)
            {
                next.SetActive(false);
            }

           //Time.timeScale = 0;
            GameObject.FindWithTag("Bomb").GetComponent<PlayerMove>().enabled = false;
            if(Scene.chpter_num ==0)
            {
                stageManager.instance.stageClaer();
            }
            if (Scene.chpter_num == 1)
            {
                stageManager.instance.stageClaer2();
                
            }


            Debug.Log("끝");
        }

        gettouch(istouch);

        remain_b.text = re_bomb.ToString();


    }

    public void gettouch(bool check)
    {
        if(check == true)
        {
            //Debug.Log("확인");

            bombs.GetComponent<PlayerMove>().enabled = true;
            bombs.GetComponent<SpriteRenderer>().sprite = n_bomb;
            
        }
        /*if(check == false)
        {
            bombs.GetComponent<PlayerMove>().enabled = false;
        }*/

    }

    void bgms()
    {
       
    }
  public void Clear()
    {
        SceneManager.LoadScene("STAGE");
    }

    public void audiocontrol(Toggle toggle)
    {
        if(toggle.isOn)
        {
                this.gameObject.GetComponent<AudioSource>().Play();
                B_BGM.gameObject.GetComponent<Image>().sprite = B_BGM_ON;
           
        }
        else
        {
            this.gameObject.GetComponent<AudioSource>().Stop();
            B_BGM.gameObject.GetComponent<Image>().sprite = B_BGM_OFF;
        }
    }


    public void PAUSE()
    {
        //Time.timeScale = 0;
        pause.SetActive(true);
        GameObject.FindWithTag("Bomb").GetComponent<PlayerMove>().enabled = false;
        PlayerMove.bm = 0;
        
    }

    public void UN_PAUSE()
    {
       // Time.timeScale = 1;
        pause.SetActive(false);
        GameObject.FindWithTag("Bomb").GetComponent<PlayerMove>().enabled = true;
        if (BLOCKM.ixe <= 8)
        {
            PlayerMove.bm = 1;
        }
        else if (BLOCKM.ixe > 8)
        {
            PlayerMove.bm = 0.84f;
        }
    }

    public void Change_backgorund(int num)
    {
        back.GetComponent<SpriteRenderer>().sprite = background[num];
    }


}


