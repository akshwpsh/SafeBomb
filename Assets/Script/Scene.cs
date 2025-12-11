using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    public static Scene instance;
    public static int chpter_num = 0; //챕터번호
    public static int c_num;
    public static int stage_num = 0;
    public Text text;

    public int n_scene;


    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "STAGE")
        {
            ChpaterSave.instance.Load();
            //Debug.Log("챕터로드");
        }

        Time.timeScale = 1;
        //Screen.SetResolution(Screen.width, (Screen.width / 9) * 16, true);
        //SET_SCREEN();
        SetCameraAsect();
    }
    public void Start()
    {

        Scene.instance = this;
        if (SceneManager.GetActiveScene().name == "CHAPTER")
        {
            chpter_num = 0; //챕터번호 초기화
        }
        //Debug.Log(BLOCKM.ixe);
    }
    private void Update()
    {
        c_num = chpter_num;

        //Debug.Log(chpter_num);  <-- 챕터번호
        if (chpter_num < 0)
        {
            chpter_num = 0;

        }
        BACKTO();
    }

    public void GAME()
    {
        ChpaterSave.instance.chapter = 0;
        ChpaterSave.instance.Save();
        Invoke("_GAME", 1f);

    }
    void _GAME()
    {

        SceneManager.LoadScene("GAME");
    }

    public void PLAY()
    {
        ChpaterSave.instance.chapter = 0;
        ChpaterSave.instance.Save();
        Invoke("_PLAY", 1f);
    }
    void _PLAY()
    {

        SceneManager.LoadScene("CHAPTER");
    }
    public void B_left() // 챕터_왼쪽버튼
    {
        chpter_num -= 1;
        ChpaterSave.instance.chapter = chpter_num;
        ChpaterSave.instance.Save();
        // Debug.Log(chpter_num);
    }
    public void B_right() // 챕터_오른쪽버튼
    {
        chpter_num += 1;
        ChpaterSave.instance.chapter = chpter_num;
        ChpaterSave.instance.Save();
        // Debug.Log(chpter_num);
    }

    public void B_start()
    {

        Invoke("_B_start", 1f);
    }
    void _B_start()
    {
        if (chpter_num == 0)
        {
            SceneManager.LoadScene("STAGE");
            //SceneManager.LoadScene("T_CHPATER_0");
        }
        else if (chpter_num == 1)
        {
            SceneManager.LoadScene("STAGE");
            //SceneManager.LoadScene("T_CHPATER_1");
        }
        else if (chpter_num == 2)
        {
            //ceneManager.LoadScene("STAGE");
        }
    }
    public void STAGE()
    {
        Invoke("_STAGE", 1f);
    }
    void _STAGE()
    {
        SceneManager.LoadScene("STAGE");
    }

    public void stage_test(int level)
    {
        stage_num = level;
        BLOCKM.ixe = level;
        //Debug.Log(BLOCKM.ixe);
        if (c_num == 1)
        {
            BLOCKM.ixe += 12;
        }
        Invoke("_PUZZLEroom", 1f);

    }

    public void TEST_BACK_STAGE()
    {
        Invoke("_TEST_BACK", 1f);
    }
    void _TEST_BACK()
    {
        SceneManager.LoadScene("STAGE");
    }





    public void PUZZLE_ROOM()
    {

        Invoke("_PUZZLEroom", 1f);
    }

    public void NEXT_STAGE()
    {
        BLOCKM.ixe += 1;
        stage_num ++;
        Invoke("_PUZZLEroom", 1f);
    }

    public void EDITOR()
    {
        SceneManager.LoadScene("EDITOR");
    }
    void _PUZZLEroom()
    {
        SceneManager.LoadScene("PUZZLE_ROOM");
        /*if (c_num == 0)
        {
            SceneManager.LoadScene("PUZZLE_ROOM");
        }
        if(c_num == 1)
        {
            BLOCKM.ixe += 12;
            SceneManager.LoadScene("PUZZLE_ROOM");
        }*/

    }
    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void BACKTO()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case "CHPATER":
                n_scene = 0;
                break;
            case "STAGE":
                n_scene = 1;
                break;
            case "PUZZLE_ROOM":
                n_scene = 2;
                break;
            case "Tutorial":
                n_scene = 1;
                break;
        }
        //SceneManager.LoadScene(n_scene);
       if(SceneManager.GetActiveScene().name == "CHAPTER")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }

       if(SceneManager.GetActiveScene().name == "")
        {

        }
    }

    void SET_SCREEN()
    {
        float targetWidthAspect = 9.0f;

        //세로 화면 비율
        float targetHeightAspect = 16.0f;

        //메인 카메라
        Camera mainCamera = Camera.main;

        mainCamera.aspect = targetWidthAspect / targetHeightAspect;

        float widthRatio = (float)Screen.width / targetWidthAspect;
        float heightRatio = (float)Screen.height / targetHeightAspect;

        float heightadd = ((widthRatio / (heightRatio / 100)) - 100) / 200;
        float widthtadd = ((heightRatio / (widthRatio / 100)) - 100) / 200;


        if (heightRatio > widthRatio)
            widthtadd = 0.0f;
        else
            heightadd = 0.0f;


        mainCamera.rect = new Rect(
            mainCamera.rect.x + Mathf.Abs(widthtadd),
            mainCamera.rect.y + Mathf.Abs(heightadd),
            mainCamera.rect.width + (widthtadd * 2),
            mainCamera.rect.height + (heightadd * 2));
    }

    public void SetCameraAsect()
    {
        Camera mainCam = UnityEngine.Camera.main;
        float targetaspect = 720.0f / 1280.0f;
        float windowaspect = 0;

#if UNITY_EDITOR
        windowaspect = (float)mainCam.pixelWidth / (float)mainCam.pixelHeight;
#else
            windowaspect = (float)Screen.width / (float)Screen.height;
#endif
        float scaleheight = windowaspect / targetaspect;
        Camera camera = UnityEngine.Camera.main;

        if (scaleheight < 1.0f)
        {
            Rect rect = camera.rect;

            rect.width = 1.0f;
            rect.height = scaleheight;
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;

            camera.rect = rect;
        }
        else
        { // add pillarbox 
            float scalewidth = 1.0f / scaleheight;

            Rect rect = camera.rect;

            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;

            camera.rect = rect;
        }
    }
}


