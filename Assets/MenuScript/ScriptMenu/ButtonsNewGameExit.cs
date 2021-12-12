using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsNewGameExit : MonoBehaviour
{
    [SerializeField] private AudioSource ButtonPlayGame;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ButtonPlayGame.Play();
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
