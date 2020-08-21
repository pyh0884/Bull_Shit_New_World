using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destorywith : MonoBehaviour
{

    bool clicked = false;
    public float speed = 0.05f;
    private void OnMouseUp()
    {
        clicked = true;
    }
    private void Update()
    {


        if (clicked)
        {

                transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
                GameObject.Destroy(gameObject, 3);
            

        }
    }
}
