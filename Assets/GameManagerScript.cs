using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public int coin;

    public TextMeshProUGUI tm; 
    void Start()
    {
        coin = PlayerPrefs.GetInt("coin");
    }

    // Update is called once per frame
    void Update()
    {
        tm.text = coin.ToString();
        PlayerPrefs.SetInt("coin", coin);
    }
}
