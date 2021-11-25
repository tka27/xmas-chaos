using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGame_Arslan : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if (GameIsPaused)
            {
                ResumE();
            }
            else
            {
                Pause();
            }
        }
    }

    public void ResumE()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = true;
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
