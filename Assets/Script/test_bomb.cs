using UnityEngine;

public class test_bomb : MonoBehaviour
{
    private GameObject target;
    public Sprite ck_bomb;
    public static Vector3 gps;

    private void Start()
    {
        gps = this.gameObject.transform.position;
        Debug.Log(gps); 
    }

    void FixedUpdate()

    {

        if (Input.GetMouseButtonDown(0))
        {

            CastRay();

            if (target == this.gameObject)
            {

                // 여기에 실행할 코드를 적습니다.
                if(naman.bombs != null)
                {
                    naman.bombs.GetComponent<PlayerMove>().enabled = false;
                    naman.bombs.GetComponent<SpriteRenderer>().sprite = ck_bomb;
                }
                naman.bombs = target;
                //Debug.Log(naman.bombs);
            }

        }

    }
    
 

    void CastRay()

    {

        target = null;



        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);



        if (hit.collider != null)

        { 
            target = hit.collider.gameObject;
        }

        


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }





}
