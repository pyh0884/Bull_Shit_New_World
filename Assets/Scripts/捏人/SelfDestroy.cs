using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public Animator obj;
    public void sd(int n) {
        if (obj != null)
        {
            obj.SetTrigger("end");
        }
        GameObject.Destroy(gameObject);
    }
}
