using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    void OnMouseDown()//点击后的判定事件
    {
        obj.SetActive(true);
        obj2.SetActive(true);
        //GameObject.Destroy(gameObject);
    }
}
