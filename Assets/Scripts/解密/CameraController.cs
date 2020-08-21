using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    GameObject cam;
    public GameObject target;
    public GameObject target2;
    public bool istarget1 = false;
    Renderer rend;
    public float speed = 0.2f;

    public GameObject target3;
    void OnMouseDown()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
            istarget1 = true;

        rend = GetComponent<Renderer>();
        rend.enabled = false;
        // 
    }

    void Update()
    {

        if (istarget1)
        {
            float step = speed * Time.deltaTime;
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, target.transform.position, step);
            if (cam.transform.position== target.transform.position)
            {
                istarget1 = false;
                target2.SetActive(true);
                target2.GetComponent<Renderer>().enabled = true;
                gameObject.SetActive(false);
            }
        }


    }
}

