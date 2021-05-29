using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log(nextLevel);
        SceneManager.LoadScene(nextLevel);
        PlayerPrefs.SetInt("levelReached", nextLevel);
    }
}
