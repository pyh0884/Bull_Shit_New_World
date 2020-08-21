using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckBaoxianNum : MonoBehaviour
{
    Text AnswerText;//答案的文本
    int numAnswertext;
    public Text ObjText;//现在变化的文本
    int numObjrtext;

    public GameObject objUpandDown100;
    public GameObject objUpandDown10;
    public GameObject objUpandDown1;

    public GameObject outdoor;
    // Start is called before the first frame update
    void Start()
    {
        AnswerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int num100 = objUpandDown100.GetComponent<BaoxianMove>().timemun;
        int num10 = objUpandDown10.GetComponent<BaoxianMove>().timemun;
        int num1 = objUpandDown1.GetComponent<BaoxianMove>().timemun;

        int.TryParse(AnswerText.text, out numAnswertext); // 答案的数组
        int numObjrtext =  num100 * 100 + num10 * 10 + num1; //现在变化的数组
        ObjText.text = numObjrtext.ToString("000");
        if (numAnswertext == numObjrtext)
        {
            GameObject.Destroy(outdoor);
        }


    }
}
