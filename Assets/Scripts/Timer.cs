using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    private bool timerIsRunning = false;
    public GameObject nextLevelPanel;

    void Start()
    {
        timerIsRunning = true;
    }
    
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                nextLevelPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
