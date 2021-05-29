using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    [SerializeField] private OrbController orbController;

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        orbController.ChangeMoving(false);
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        orbController.ChangeMoving(true);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}