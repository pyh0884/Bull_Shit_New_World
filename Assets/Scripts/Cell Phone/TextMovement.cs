using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMovement : MonoBehaviour
{
    public GameObject text1; //为了实现动画效果，摧毁当前现实的文字，然后播放text1的动画。 效果为原来的文字消失后出现在屏幕中间，逐渐缩小并移动到新的位置。
    public void Move()
    {
        text1.SetActive(true);
        GameObject.Destroy(gameObject);
    }
    
}
