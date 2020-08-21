using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAppearance : MonoBehaviour
{
    public SpriteRenderer BodyPart;
    public int AppNumber = 1;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;

    void Update()
    {
        if (AppNumber == 1)
        {
            BodyPart.sprite = sprite1;
            //BodyPart.SetNativeSize();
        }
        else if (AppNumber == 2)
        {
            BodyPart.sprite = sprite2;
            //BodyPart.SetNativeSize();
        }
        else if (AppNumber == 3)
        {
            BodyPart.sprite = sprite3;
            //BodyPart.SetNativeSize();
        }
        else if (AppNumber == 4)
        {
            BodyPart.sprite = sprite4;
            //BodyPart.SetNativeSize();
        }
        else if (AppNumber == 5)
        {
            BodyPart.sprite = sprite5;
            //BodyPart.SetNativeSize();
        }
        else if (AppNumber == 6)
        {
            BodyPart.sprite = sprite6;
            //BodyPart.SetNativeSize();
        }
    }

    public void ChangeAppByNumber(int n)
    {
        AppNumber = n;
    }
}
