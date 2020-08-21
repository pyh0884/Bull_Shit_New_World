using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    Vector3 startPosition;
    Transform myTransform;
    Vector3 selfScenePosition;

    public bool isTarget;

    public GameObject target;

    void Start()
    {
        //获取初始坐标
        startPosition = transform.position;
        myTransform = transform;
        //将自身坐标转换为屏幕坐标
        selfScenePosition = Camera.main.WorldToScreenPoint(myTransform.position);
        
        //判定是否在目标区域内
        isTarget = true;
    }

    void OnMouseDrag() //鼠标拖拽时系统自动调用该方法
    {

        //新的屏幕点坐标
        Vector3 currentScenePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, selfScenePosition.z);
        //将屏幕坐标转换为世界坐标
        Vector3 crrrentWorldPosition = Camera.main.ScreenToWorldPoint(currentScenePosition);
        //设置对象位置为鼠标的世界位置
        myTransform.position = crrrentWorldPosition;
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == target)
        {
            isTarget = false;
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == target)
        {
            isTarget = true;
        }

    }



    void OnMouseUp()
    {
        if (isTarget == true)
        {
            myTransform.position = startPosition;

        }else
        {
            Destroy(gameObject);

        }

    }


}