using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus : MonoBehaviour
{
    public GameObject obj;
    private void OnMouseUp()
    {
        obj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
