using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject can1;
    public GameObject can2;
    public GameObject can3;
    public GameObject can4;
    public GameObject can5;
    public GameObject pure;
    void changescene()
    {
        can1.SetActive(false);
        can2.SetActive(false);
        can3.SetActive(false);
        can4.SetActive(false);
        can5.SetActive(false);
        pure.SetActive(true);
        GameObject.Destroy(gameObject);
    }
    void dialogue()
    {
        can1.SetActive(true);
    }
}
