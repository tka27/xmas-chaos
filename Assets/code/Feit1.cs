using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Feit1 : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;

    public Vector2 position;
    public VectorValue playerStorage;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("fabe");
    }

    public void OnFadeComplete()
    {
        playerStorage.initialValue = position;
        SceneManager.LoadScene(levelToLoad);
    }
}
