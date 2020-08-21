using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnim : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public void des()
    {
        GameObject.Destroy(anim);
    }
    public void charaMove(){
        anim2.SetTrigger("move");
    }
}
