using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    //为了动画效果不会在后续转场时重新播放，摧毁当前的文字，并显示原先隐藏的文字。
    public GameObject text;

    public void Change()    
    {
        text.SetActive(true);
        GameObject.Destroy(gameObject);
    }
}
