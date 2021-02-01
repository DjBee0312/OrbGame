using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject restartPanel;
    public void GameOver()
    {
        Invoke("Delay", 1.5f);
    }

    private void Delay()
    {
        restartPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Levels");
    }
    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
