using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class text : MonoBehaviour
{
    //输入的文本
    InputField inputField;

    //问题的文本
    public string questiontext;
    public Text question;
    public Trans trn;
    public Trans trnEnd;
    void Start()
    {
        inputField = GetComponent<InputField>();
        question.text = questiontext;
        inputField.characterLimit = questiontext.Length;//限制输入字符数量
    }

    void Update()
    {
        string text = inputField.text;
        print(text.Length);

        //问题转大写
        if (questiontext != inputField.text.ToUpper())
        {
            question.text = question.text.ToUpper();
            questiontext = questiontext.ToUpper();
        }
        //输入转大写
        if (text != inputField.text.ToUpper())
        {
            inputField.text = inputField.text.ToUpper();
        }


        //和回答相符合
        if (text == questiontext)
        {
            //print("right");
            if (trnEnd != null) trnEnd.LoadScene(0);
            if (trn!=null)trn.NextScene();
        }
        //和回答不符合
        if (text.Length == questiontext.Length && text != questiontext)
        {
            
            print("wrong");
            Invoke("Delettext", 0.5f);//延迟执行清除文本
            

        }
    }
    void Delettext()
    {
        inputField.text = "";
    }

    }

