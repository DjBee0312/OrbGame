using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public void PlayClick()
    {
        FindObjectOfType<SoundManager>().Play("Click");
    }
}
