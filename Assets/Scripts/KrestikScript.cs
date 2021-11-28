using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KrestikScript : MonoBehaviour
{
    public GameObject pause;

    public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
