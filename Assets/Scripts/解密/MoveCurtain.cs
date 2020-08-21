using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCurtain : MonoBehaviour
{
    public GameObject obj;
    bool clicked=false;
    public GameObject book;
    private void OnMouseUp()
    {
        clicked = true;
    }
    private void Update()
    {
        if (clicked)
        {
            if (obj != null)
            {
                obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y + 0.01f, obj.transform.position.z);
               
                GameObject.Destroy(obj, 5);
                if (book != null)
                    book.SetActive(true);
            }
        }
    }
}
