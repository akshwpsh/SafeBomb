using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ED_TESTD : MonoBehaviour
{
    void Update()
    {
        MouseDrag();
    }

    IEnumerator MouseDrag()
    {
        while (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldObjectPositon = Camera.main.ScreenToWorldPoint(mousePosition);
            this.gameObject.transform.position = worldObjectPositon;
            yield return null;
        }
    }
}
