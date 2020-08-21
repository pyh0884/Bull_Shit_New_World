using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaoxianMove : MonoBehaviour
{
    float rz;//用于读取钟表的角度
    public int timemun;//用于获取旋转后的时间


    bool isclock1;//判定用户是否点击到时针
    bool isclock2;//判定用户是否点击到分针
    // Use this for initialization
    void Start()
    {
        isclock1 = false;
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "clock1")
        {
            isclock1 = true;
        }
        else
        {
            isclock1 = false;
        }

        if (gameObject.tag == "clock2")
        {
            isclock2 = true;
        }
        else
        {
            isclock2 = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        rz = gameObject.GetComponent<Transform>().localEulerAngles.z;//获取指针旋转角度
                                                                     //print(rz);

        /////////////////旋转指针//////////////////////////////////////////////////////////////////////////////


        if (Input.GetMouseButton(0) && isclock1 == true)//鼠标拖动旋转时针
        {
            //获取鼠标的坐标，鼠标是屏幕坐标，Z轴为0，这里不做转换
            Vector3 mouse = Input.mousePosition;
            //获取物体坐标，物体坐标是世界坐标，将其转换成屏幕坐标，和鼠标一直
            Vector3 obj = Camera.main.WorldToScreenPoint(transform.position);
            //屏幕坐标向量相减，得到指向鼠标点的目标向量，即黄色线段
            Vector3 direction = mouse - obj;
            //将Z轴置0,保持在2D平面内
            direction.z = 0f;
            //将目标向量长度变成1，即单位向量，这里的目的是只使用向量的方向，不需要长度，所以变成1
            direction = direction.normalized;
            //物体自身的Y轴和目标向量保持一直，这个过程XY轴都会变化数值
            transform.up = direction;
        }
        /////////////////鼠标松开，自动归位到最近的整数点//////////////////////////////////////////////////////////////////////////////


        if (Input.GetMouseButtonUp(0))
        {
            isclock1 = false;
            isclock2 = false;

            if (rz > 20 && rz <= 60) 
            {
                timemun = 9;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 40);
            }
            if (rz > 60 && rz <= 100) 
            {
                timemun = 8;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 80);
            }
            if (rz > 100 && rz <= 140) 
            {
                timemun = 7;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 120);
            }
            if (rz > 140 && rz <= 180) 
            {
                timemun = 6;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 160);
            }
            if (rz > 180 && rz <= 220)
            {
                timemun = 5;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 200);
            }
            if (rz > 220 && rz <= 260) 
            {
                timemun = 4;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 240);
            }
            if (rz > 260 && rz <= 300) 
            {
                timemun = 3;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 280);
            }
            if (rz > 300 && rz <= 340)
            {
                timemun = 2;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 320);
            }
            if (rz > 340 || rz <= 20) 
            {
                timemun = 1;
                gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
            }

        }

    }
}
