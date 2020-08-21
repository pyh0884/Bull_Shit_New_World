using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextdialogue : MonoBehaviour
{
    public GameObject obj;
    public Animator trans;
    public Trans trn;
    private void OnMouseUp()
    {
        //if (trn != null) trn.NextScene();
        if (trans != null)
        {
            trans.SetTrigger("end");
        }
        obj.SetActive(true);
        gameObject.SetActive(false);
    }
}
