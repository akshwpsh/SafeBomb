using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fsfsd : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    public LayerMask layerMask;
    public float speed;
    private Vector2 direction;
    private Animator animator;
    public float keycount;

    public bool isopen = false;
    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (count == 5)
        {
            isopen = true;
        }

        GetInput();
        Move();
        AnimateMovement();
        Vector3 pos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (pos.x < 0.06f) pos.x = 0.06f;
        if (pos.x > 0.94f) pos.x = 0.94f;
        if (pos.y < 0.1f) pos.y = 0.1f;
        if (pos.y > 0.9f) pos.y = 0.9f;
        this.transform.position = Camera.main.ViewportToWorldPoint(pos);

        
        


    }
    public void Move()//캐릭터 이동(방향,스피드)

    {
        transform.Translate(direction * speed * Time.deltaTime);


    }
    private void AnimateMovement()
    {


        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);


    }
    private void GetInput()
    {
        Vector2 moveVector;
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");
        direction = moveVector;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "door")
        {
            if(isopen == true)
            {
                Debug.Log("ㄹㄹㄹ");
                SceneManager.LoadScene("TEST");
            }
        }
        if(collision.gameObject.tag == "1")
        {
            count += 1;
            Destroy(collision.gameObject);
            Debug.Log(count);
            Debug.Log("eee");
        }
        else if (collision.gameObject.tag == "2")
        {
            count += 1;
            Destroy(collision.gameObject);
            Debug.Log(count);
        }
        else if (collision.gameObject.tag == "3")
        {
            count += 1;
            Destroy(collision.gameObject);
            Debug.Log(count);
        }
        else if (collision.gameObject.tag == "4")
        {
            count += 1;
            Destroy(collision.gameObject);
            Debug.Log(count);
        }


    }


}
