using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public GameObject character;
    public Animator anim;
    public void ShowCharacter()
    {
        gameObject.SetActive(false);
        anim.SetTrigger("move");
    }
}
