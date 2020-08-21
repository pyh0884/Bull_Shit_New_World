using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpandDown : MonoBehaviour
{
    /// <summary>
    /// 这个脚本变更对象位置时一定要注意对象起始位置，这个代码只能实现物体在两个位置的变更，且y的初始位置必须在PositionUp或者PositionDown中的某一点，否则代码将无法工作。
    /// </summary>
    

    bool movetosup = false;
    public int isup;
    bool movetosdown = false;

    public float MoveSpeed = 3f;

    //y值移动到的目标坐标，为本地坐标
    public float PositionUp = 1f;
    public float PositionDown = -1f;


    void Start()
    {

    }
    void OnMouseDown()//点击后的判定事件
    {
        if(isup == 0)
        {
            movetosup = true;
        }
        if (isup == 1)
        {
            movetosdown = true;
        }
    }
    void Update()
    {
        ///////////////////////////////////判断对象当前所处的位置///////////////////////////////////////
        ///
        if (transform.localPosition.y == PositionUp)
        {
            isup = 1;
        }
        if (transform.localPosition.y == PositionDown)
        {
            isup = 0;
        }
        ///////////////////////////////////点击后更替位置///////////////////////////////////////
        //上移
        if (movetosup)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.position.x, PositionUp, 0), Time.deltaTime* MoveSpeed);
            if(transform.localPosition.y== PositionUp)
            {
                movetosup = false;
            }
        }
        //下移
        if (movetosdown)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.position.x, PositionDown, 0), Time.deltaTime * MoveSpeed);
            if (transform.localPosition.y == PositionDown)
            {
                movetosdown = false;
            }
        }


    }
}
