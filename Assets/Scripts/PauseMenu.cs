using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu menu;
    [SerializeField] private GameObject pausePanel = null;
    private void Awake()
    {
        menu = this;
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void RestartLevel()
    {
        Resume();
        SceneManager.LoadScene("ForestLevel");
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
