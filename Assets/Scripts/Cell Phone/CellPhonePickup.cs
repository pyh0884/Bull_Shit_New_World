using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellPhonePickup : MonoBehaviour
{
    public GameObject CellPhoneCanvas;
    public GameObject obj;
    private void OnMouseUp()
    {
        GameObject.Destroy(obj);
        CellPhoneCanvas.SetActive(true);
    }
}
