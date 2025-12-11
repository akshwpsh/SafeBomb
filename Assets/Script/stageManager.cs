using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stageManager : MonoBehaviour
{
    public static stageManager instance;
    public Button[] stageBT;
    public int[] _stage;// 0: 클리어 (X) , 1: 클리어 (O)
    public int[] _stage2;
    public static int stageLevel = 1;
    public static int stageLevel2 = 0;
    public string isStageClaer;
    public string is2StageClaer;

    public Sprite Lock;
    public Sprite UNLock;

    public Sprite[] backgrounds;
    private void Awake()
    {
        instance = this;
      
    }
    void Start()
    {
        if(PlayerPrefs.HasKey("stageLevel"))
        {
            Load();
        }
        if(Scene.c_num == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = backgrounds[0];
        }
        else if(Scene.c_num == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = backgrounds[1];
        }

    }
    private void Update()
    {
        //Debug.Log(Scene.chpter_num);
    }
    public void stageLoad()
    {
        
        AllLock();
       
        Debug.Log(stageLevel);
        //Debug.Log(stageLevel2);
        Debug.Log("챕터넘버 "+Scene.chpter_num);

        if (Scene.chpter_num == 0)
        {
            for (int i = 0; i < stageLevel; i++)
            {
                stageBT[i].interactable = true;
                {
                    stageBT[i].GetComponent<Image>().sprite = UNLock;
                    stageBT[i].transform.GetChild(0).gameObject.SetActive(true);
                }
                //Debug.Log("잠금헤제");
               
            }
           /* for (int i = stageLevel; i>12; i++)
            {
                if (stageBT[i].interactable == false)
                {
                    stageBT[i].GetComponent<Image>().sprite = Lock;
                }
            }
            */
        }

        if (Scene.chpter_num == 1)
        {
            for (int i = 0; i < stageLevel2; i++)
            {
                stageBT[i].interactable = true;
                {
                    stageBT[i].GetComponent<Image>().sprite = UNLock;
                    stageBT[i].transform.GetChild(0).gameObject.SetActive(true);
                }
                //Debug.Log("잠금헤제");

            }
         /*   for (int i = stageLevel; i > 12; i++)
            {
                if (stageBT[i].interactable == false)
                {
                    stageBT[i].GetComponent<Image>().sprite = Lock;
                }
            }*/
        }
    }
    void AllLock()
    {
        for (int i = 0; i < 12; i++)
        {
            stageBT[i].interactable = false;
            if(stageBT[i].interactable == false)
            {
                stageBT[i].GetComponent<Image>().sprite = Lock;
                stageBT[i].transform.GetChild(0).gameObject.SetActive(false);
            }

        }
    }
   public void stageClaer()
    {
        if(_stage[Scene.stage_num]==0)
        {
            stageLevel++;
            if(stageLevel>12)
            {
                stageLevel--;
                stageLevel2++;
            }
            _stage[Scene.stage_num] = 1;
            Debug.Log("슈발");
        }

        
        Save();
        
    }
    public void stageClaer2()
    {
        if (_stage2[Scene.stage_num] == 0 )
        {
            stageLevel++;
            if (stageLevel > 12)
            {
                stageLevel--;
                stageLevel2++;
            }
            _stage2[Scene.stage_num] = 1;
            Debug.Log("야발");
        }
        Save();
    }
    public void Save()
    {

        PlayerPrefs.SetInt("stageLevel", stageLevel);
        PlayerPrefs.SetInt("stageLevel2", stageLevel2);

        for (int i = 0; i < 12; i++)
        {
            isStageClaer = "isStageClaer" + i;
            PlayerPrefs.SetInt(isStageClaer,_stage[i]);
        }
        for (int i = 0; i < 12; i++)
        {
            is2StageClaer = "is2StageClaer" + i;
            PlayerPrefs.SetInt(is2StageClaer, _stage2[i]);
        }
    }

    public void Load()
    {
        stageLevel = PlayerPrefs.GetInt("stageLevel");
        stageLevel2 = PlayerPrefs.GetInt("stageLevel2");
        for (int i = 0; i < 12; i++)
        {
            isStageClaer = "isStageClaer" + i;
            _stage[i] = PlayerPrefs.GetInt(isStageClaer);
        }
        for (int i = 0; i < 12; i++)
        {
            is2StageClaer = "is2StageClaer" + i;
            _stage2[i] = PlayerPrefs.GetInt(is2StageClaer);
        }

    }
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
