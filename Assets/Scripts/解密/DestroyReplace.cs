using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyReplace : MonoBehaviour
{
    public GameObject obj;
    public void replace()
    {
        obj.SetActive(true);
        GameObject.Destroy(gameObject);
    }
}
