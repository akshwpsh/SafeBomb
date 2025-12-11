using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject bomb;
    public float pos_y;
    public float pos_x;
    public float pos2_y;
    public float pos2_x;
    public float posY;
    public float posX;
    public bool istouch;
    public bool isbomb = false;
    public Vector3 point;

    public static float bm;

    public Vector3 gps;
    // Start is called before the first frame update

    public void Awake()
    {
        gps = this.gameObject.transform.position;
    }
    void Start()
    {
        point = this.transform.position;
        if (BLOCKM.ixe <= 8)
        {
            bm = 1;
        }
        else if (BLOCKM.ixe <= 11)
        {
            bm = 0.84f;
        }
        else if(BLOCKM.ixe <= 20)
        {
            bm = 1;
        }
        else if (BLOCKM.ixe <= 24)
        {
            bm = 0.84f;
        }


    }

    // Update is called once per frame
    void Update()
    {


        /* if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
         {
             RaycastHit hit = new RaycastHit();
             Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
             if(Physics.Raycast(ray, out hit))
             {
                 if(hit.collider.tag == "Bomb")//터치한 오브젝트 태그가 Bomb이라면
                 {
                     bomb = hit.collider.gameObject;
                     isbomb = true;
                 }
             }
         }//터치로 폭탄 변경

         if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began && istouch == false && isbomb == true)//처음터치 좌표얻기
         {
            pos_y = Input.GetTouch(0).position.y;
             pos_x = Input.GetTouch(0).position.x;
             istouch = true;
         }
         if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended && istouch == true)//터치끝날때 좌표얻기
         {
             pos2_y = Input.GetTouch(0).position.y;
             pos2_x = Input.GetTouch(0).position.x;
             if (pos2_y > pos_y && istouch == true && Mathf.Abs(pos2_y - pos_y) > Mathf.Abs(pos2_x - pos_x))//
             {
                 gps = this.gameObject.transform.position;
                 Debug.Log(gps);
                 pos_y = 0;
                 pos2_y = 0;
                 bomb.transform.Translate(new Vector3(0, 1, 0));
                 //Debug.Log("위로이동");
                 istouch = false;

             }
             else if (pos_y > pos2_y && istouch == true && Mathf.Abs(pos2_y - pos_y) > Mathf.Abs(pos2_x - pos_x))
             {

                 gps = this.gameObject.transform.position;
                 Debug.Log(gps);
                 pos_y = 0;
                 pos2_y = 0;
                 bomb.transform.Translate(new Vector3(0, -1, 0));
                 //Debug.Log("아래로이동");
                 istouch = false;
             }


             if (pos2_x > pos_x && istouch == true && Mathf.Abs(pos2_x - pos_x) > Mathf.Abs(pos2_y - pos_y))
             {
                 gps = this.gameObject.transform.position;
                 Debug.Log(gps);
                 pos_x = 0;
                 pos2_x = 0;
                 bomb.transform.Translate(new Vector3(1, 0, 0));
                 //Debug.Log("오른쪽 이동");
                 istouch = false;
             }
             else if (pos_x > pos2_x && istouch == true && Mathf.Abs(pos2_x - pos_x) > Mathf.Abs(pos2_y - pos_y))
             {
                 gps = this.gameObject.transform.position;
                 Debug.Log(gps);
                 pos2_x = 0;
                 pos_x = 0;
                 bomb.transform.Translate(new Vector3(-1, 0, 0));
                 //Debug.Log("왼쪽이동");
                 istouch = false;
             }

         }//터치 처리
         */
        /*if (Input.GetMouseButtonDown(0))
        {
            
            CastRay();
            if (bomb.tag =="Bomb")
            {
                isbomb = true;
               
            }
           
        }*/
            if (Input.GetMouseButtonDown(0) && istouch == false && isbomb == true)
        {
            pos_y = Input.mousePosition.y;
            pos_x = Input.mousePosition.x;
            istouch = true;
        }
        if (Input.GetMouseButtonUp(0) && istouch == true && isbomb == true)
        {
            pos2_y = Input.mousePosition.y;
            pos2_x = Input.mousePosition.x;
            if (pos2_y > pos_y &&istouch == true && Mathf.Abs(pos2_y-pos_y)> Mathf.Abs(pos2_x - pos_x))
            {
                gps = this.gameObject.transform.position;
                //Debug.Log(gps);
                pos_y = 0;
                pos2_y = 0;
                bomb.transform.Translate(new Vector3(0, bm, 0));
                //Debug.Log("위로이동");
                istouch = false;

            }
            else if (pos_y > pos2_y  && istouch == true && Mathf.Abs(pos2_y - pos_y) > Mathf.Abs(pos2_x - pos_x))
            {
                gps = this.gameObject.transform.position;
                //Debug.Log(gps);
                pos_y = 0;
                pos2_y = 0;
                bomb.transform.Translate(new Vector3(0, -bm, 0));
                //Debug.Log("아래로이동");
                istouch = false;
            }


            if(pos2_x>pos_x&& istouch == true && Mathf.Abs(pos2_x - pos_x) > Mathf.Abs(pos2_y - pos_y))
            {
                gps = this.gameObject.transform.position;
                //Debug.Log(gps);
                pos_x = 0;
                pos2_x = 0;
                bomb.transform.Translate(new Vector3(bm, 0, 0));
                //Debug.Log("오른쪽 이동");
                istouch = false;
            }
            else if(pos_x > pos2_x && istouch == true && Mathf.Abs(pos2_x - pos_x) > Mathf.Abs(pos2_y - pos_y))
            {
                gps = this.gameObject.transform.position;
                //Debug.Log(gps);
                pos2_x = 0;
                pos_x = 0;
                bomb.transform.Translate(new Vector3(-bm, 0, 0));
                //Debug.Log("왼쪽이동");
                istouch = false;
            }// 클릭 테스트
           
        }

        
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "WALL")
        {
            this.transform.position = gps;
            //Debug.Log("닿았다!");
        }
        if (collision.tag == "Bomb")
        {
            this.transform.position = gps;
            //Debug.Log("닿았다!");
        }
        if (collision.tag == "OUT")
        {
            this.transform.position = gps;
        }
    }
    void CastRay()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if(hit.collider != null&&hit.collider.tag == "Bomb")
        {
            bomb = hit.collider.gameObject;
            //Debug.Log("폭탄지정");
        }
    }

    private void OnMouseDown()
    {
        CastRay();
        if (bomb.tag == "Bomb")
        {
            isbomb = true;

        }
        //this.transform.position = new Vector3(point.x, point.y, -3);
    }
}
