using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Mute("BGM");
        FindObjectOfType<AudioManager>().UnMute("Dash");
    }
}
