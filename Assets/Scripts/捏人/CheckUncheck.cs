using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUncheck : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public void UncheckOther(int n)
    {
        switch (n)
        {
            case 1:
                image1.SetActive(true);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                break;
            case 2:
                image2.SetActive(true);
                image1.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                break;
            case 3:
                image3.SetActive(true);
                image2.SetActive(false);
                image1.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                break;
            case 4:
                image4.SetActive(true);
                image2.SetActive(false);
                image3.SetActive(false);
                image1.SetActive(false);
                image5.SetActive(false);
                image6.SetActive(false);
                break;
            case 5:
                image5.SetActive(true);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image1.SetActive(false);
                image6.SetActive(false);
                break;
            case 6:
                image6.SetActive(true);
                image2.SetActive(false);
                image3.SetActive(false);
                image4.SetActive(false);
                image5.SetActive(false);
                image1.SetActive(false);
                break;
            case 7:
                image6.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(true);
                image4.SetActive(true);
                image5.SetActive(false);
                image1.SetActive(false);
                break;
        }
    }
}
