using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private Score _score;
    public GameObject restartPanel;

    private void Start()
    {
        _score = GameObject.Find("Canvas").GetComponent<Score>();
    }

    public void GameOver()
    {
        _score.hasLost = true;
        restartPanel.SetActive(true);
    }
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Game");
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
