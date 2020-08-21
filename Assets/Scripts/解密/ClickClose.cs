using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickClose : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    private void OnMouseUp()
    {
        obj1.SetActive(false);
        obj2.SetActive(false);
    }
}
