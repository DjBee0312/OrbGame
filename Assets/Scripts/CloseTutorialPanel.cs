using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTutorialPanel : MonoBehaviour
{
    public GameObject tutorialPanel;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void ClosePanel()
    {
        tutorialPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
