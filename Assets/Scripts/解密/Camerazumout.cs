using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerazumout : MonoBehaviour
{
    public static bool clicked = false;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnMouseUp()
    {
        clicked = true;
        CameraZum.clicked = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (clicked)
        {
            camera.orthographicSize = camera.orthographicSize + 4 * Time.deltaTime;
            if (camera.orthographicSize > 5f)
            {
                camera.orthographicSize = 5f; // Min size 
                clicked = false;
            }
        }
    }
}

