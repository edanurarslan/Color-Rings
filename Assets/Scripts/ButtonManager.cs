using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    public GameObject homeScreen;
    public GameObject startScreen;
    public GameObject optionsMenu;
    private string urlInsta = "https://www.instagram.com/quadcengame/?igshid=ZDdkNTZiNTM%3D";
    private string urlLinkedn = "https://www.linkedin.com/company/quadcen-game/";
    private string urlFacebook = "https://www.facebook.com/quadcengame?mibextid=ZbWKwL";
    private string urlX = "https://twitter.com/quadcen?s=11";

    public void HomeScreenOpen()
    {
        optionsMenu.SetActive(false);
        homeScreen.SetActive(true);
    }

    public void OptionsMenuOpen()
    {
        homeScreen.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void StartScreenOpen()
    {
        homeScreen.SetActive(false);
        optionsMenu.SetActive(false);
        //startScreen.SetActive(true);
    }
    public void OpenInstagram(string url)
    {
        Application.OpenURL(urlInsta);
    }

    public void OpenLinkedn(string url)
    {
        Application.OpenURL(urlLinkedn);
    }

    public void OpenX(string url)
    {
        Application.OpenURL(urlX);
    }

    public void OpenFacebook(string url)
    {
        Application.OpenURL(urlFacebook);
    }

}
