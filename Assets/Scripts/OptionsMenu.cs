using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    /*void Start()
    {
        
    }

    void Update()
    {
        
    }*/

    [SerializeField] private Toggle muteToggle;

    private void Awake()
    {
        if(!PlayerPrefs.HasKey("Mute"))
        {
            PlayerPrefs.SetInt("Mute", 0);
        }
        else
        {
            LoadMuteToggle();
        }
    }

    private void LoadMuteToggle()
    {
        PlayerPrefs.SetInt("Mute", muteToggle.isOn ? 1 : 0);

        if(muteToggle.isOn)
        {
            AudioListener.pause = true;
        }
        else
        {
            AudioListener.pause = false;
        }        
    }



}
