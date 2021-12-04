using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume = 1f;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.GetFloat("Volume", musicVolume);
        }
        else
        {
            audioSrc = GetComponent<AudioSource>();
        }
    }
    void Update()
    {
        audioSrc.volume = musicVolume;
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("Volume", audioSrc.volume);
    }

}
