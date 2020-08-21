using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator anim;
    private void OnMouseUp()
    {
        anim.SetTrigger("end");
    }
}
