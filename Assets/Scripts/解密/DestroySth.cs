using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySth : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public Animator anim;
    public Collider2D col;
    public void des() {
        if (obj1 != null) { GameObject.Destroy(obj1); }
        if (obj2 != null) { GameObject.Destroy(obj2); }
        if (obj3 != null) { GameObject.Destroy(obj3); }
        if (obj4 != null) { GameObject.Destroy(obj4); }
        if (obj5 != null) { GameObject.Destroy(obj5); }
    }
    private void OnMouseUp()
    {
        if (obj1 != null) { GameObject.Destroy(obj1); }
        if (obj2 != null) { GameObject.Destroy(obj2); }
        if (obj3 != null) { GameObject.Destroy(obj3); }
        if (obj4 != null) { GameObject.Destroy(obj4); }
        if (obj5 != null) { obj5.SetActive(true); }
        if (obj6 != null) { obj6.SetActive(true); }
        if (anim != null) { anim.SetTrigger("end"); }
    }
    public void abc()
    {
        GameObject.Destroy(obj6);
    }
    public void abcd()
    {if(col!=null)
        col.enabled = true;
    }
}
