using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ED_BLOCK : MonoBehaviour
{

    private GameObject target;
    public GameObject tddf;
    public GameObject[] block;
    // Start is called before the first frame update

    
    void FixedUpdate()

    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("마우스 클릭");
            CastRay();

            if (target == this.gameObject)
            {
                
               if(ED_EDITOR.witch.x != 0)
                {
                    Instantiate(this.gameObject, new Vector3(ED_EDITOR.witch.x, ED_EDITOR.witch.y, -1), Quaternion.identity);
                    //Debug.Log("선택");
                }
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
        if(collision.tag == "WALL")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        if(collision.tag == "OUT")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
