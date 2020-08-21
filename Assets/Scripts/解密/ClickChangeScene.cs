using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickChangeScene : MonoBehaviour
{
    public Trans trn;
    private void OnMouseUp()
    {
        trn.NextScene();
    }
}
