using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer BodyPart;
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public int ColorNumber = 1;

    void Update()
    {
        GameObject bp = GameObject.Find("Hair");
        
        if (ColorNumber == 1)
        {
            BodyPart.color = color1;
        }
        else if (ColorNumber == 2)
        {
            BodyPart.color = color2;
        }
        else if (ColorNumber == 3)
        {
            BodyPart.color = color3;
        }
        else if (ColorNumber == 4)
        {
            BodyPart.color = color4;
        }
        else if (ColorNumber == 5)
        {
            BodyPart.color = color5;
        }
    }

    public void ChangeColorByNumber(int colorNumber)
    {
        ColorNumber = colorNumber;
    }

}
