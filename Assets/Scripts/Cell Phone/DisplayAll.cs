using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAll : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public GameObject obj16;
    public GameObject cell;
    public GameObject dialogue;
    private void Update()
    {
        if (obj1 == null && obj2 == null && obj3 == null && obj4 == null && obj5 == null && obj6 == null && obj7 == null && obj8 == null)
        {
            GameObject.Destroy(cell);
            obj9.SetActive(true);
            obj10.SetActive(true);
            obj11.SetActive(true);
            obj12.SetActive(true);
            obj13.SetActive(true);
            obj14.SetActive(true);
            obj15.SetActive(true);
            obj16.SetActive(true);
            if (dialogue!=null)
            dialogue.SetActive(true);
        }
    }
}
