using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    //public Text volumeAmount;

    public Slider slider;

    void Start()
    {
        LoadMusic();
    }
    public void SetMusic(float value)
    {
        AudioListener.volume = value;
        //volumeAmount.text = ((int)(value*100)).ToString();
        SaveMusic();
    }

    private void SaveMusic()
    {
        PlayerPrefs.SetFloat("musicVolume", AudioListener.volume);
    }

    private void LoadMusic()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("musicVolume");
            slider.value = PlayerPrefs.GetFloat("musicVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("musicVolume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("musicVolume");
            slider.value = PlayerPrefs.GetFloat("musicVolume");
        }

    
    }

}
