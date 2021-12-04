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

        if (!PlayerPrefs.HasKey("Volume"))
        {
            PlayerPrefs.SetFloat("Volume", musicVolume);
            Load();
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
    private void Load()
    {
       musicVolume = PlayerPrefs.GetFloat("Volume");
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
        Save();
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", musicVolume);
    }

}
