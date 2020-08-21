using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckUpandDown : MonoBehaviour
{
    Text AnswerText;//答案的文本
    int numAnswertext;

    public Text ObjText;//现在变化的文本
    int numObjrtext;
    public Collider2D col;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    // 现在弄了可以做4个答案，后面可以根据需要复制并修改该脚本

    public GameObject objUpandDown1000;
    public GameObject objUpandDown100;
    public GameObject objUpandDown10;
    public GameObject objUpandDown1;
    public GameObject obj;

    int num1;
    int num2;
    int num3;
    int num4;

    //int n;
    // Start is called before the first frame update
    void Start()
    {
        AnswerText = gameObject.GetComponent<Text>();
         
    }

    // Update is called once per frame
    void Update()
    {

        num1 = objUpandDown1000.GetComponent<UpandDown>().isup;
        num2 = objUpandDown100.GetComponent<UpandDown>().isup;
        num3 = objUpandDown10.GetComponent<UpandDown>().isup;
        num4 = objUpandDown1.GetComponent<UpandDown>().isup;
      

        int.TryParse(AnswerText.text, out numAnswertext); // 答案的数组
        numObjrtext = num1 * 1000 + num2 * 100 + num3 * 10 + num4; //现在变化的数组
        ObjText.text = numObjrtext.ToString("0000");

        if (numAnswertext == numObjrtext)
        {
            //AnswerText.text = "GOOD!!";
            col.enabled = true;
            obj1.SetActive(false);
            obj2.SetActive(false);
            if (obj3 != null) obj3.SetActive(true);
            GameObject.Destroy(obj);
        }
    }
}
