using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZum : MonoBehaviour
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
        Camerazumout.clicked = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (clicked)
        {
            camera.orthographicSize = camera.orthographicSize - 4 * Time.deltaTime;
            if (camera.orthographicSize < 1.2f)
            {
                camera.orthographicSize = 1.2f; // Min size 
                clicked = false;
            }
        }
    }
}
