using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public bool hasLost = false;
    
    public Text score;

    void Update()
    {
        if (hasLost == false)
        {
            score.text = Time.time.ToString("F0");
        }
    }
}
