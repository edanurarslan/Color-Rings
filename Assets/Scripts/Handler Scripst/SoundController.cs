using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioSource completeSound;
    public AudioSource gameFailSound;

    private void Start()
    {
        // Başlangıçta sesleri durdur veya devre dışı bırak
        gameFailSound.Stop(); // İlk sesi durdur
        completeSound.enabled = false; // İkinci sesin bileşenini devre dışı bırak
    }

    public void OnPlayButtonClicked()
    {
        // Play butonuna basıldığında sesleri çal veya etkinleştir
        completeSound.Play(); // İlk sesi çal
        gameFailSound.enabled = true; // İkinci sesin bileşenini etkinleştir
    }
}
