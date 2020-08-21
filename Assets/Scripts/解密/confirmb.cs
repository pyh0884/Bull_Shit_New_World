using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmb : MonoBehaviour
{
    public GameObject time0;
    public GameObject time1;
    public GameObject time2;
    public GameObject time3;
    public GameObject time33;
    public int onclicktime = 0;

    bool isCD = false;
    float timer = 1;
    // Update is called once per frame
    private void OnMouseUp()
    {
        if(isCD == false)
        {
            timer = 1;
            onclicktime++;

        }
        
    }
    private void Update()
    {

       if(onclicktime == 1)
        {
            if (time1 != null) { time1.SetActive(true); }
            if (time0 != null)
            { GameObject.Destroy(time0); }
            isCD = true;
            
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                isCD = false;
            }
        }
        else if (onclicktime == 2)
        {
            if (time2 != null) { time2.SetActive(true); }
            if (time1 != null)
            { GameObject.Destroy(time1); }
            isCD = true;

            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                isCD = false;
            }
        }
        else if (onclicktime >= 3)
        {
            if (time1 != null)
            { time1.SetActive(false); }
            if (time2 != null)
            { time2.SetActive(false); }

            time3.SetActive(true);
            time33.SetActive(true);
            isCD = true;

            GameObject.Destroy(gameObject);
        }
    }
}
