using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrestikScript : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pause;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

        
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
