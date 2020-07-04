using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator GameTitle;
    public Animator RocketFly;

    private void Start()
    {
        GameTitle.SetTrigger("Title");
        RocketFly.SetTrigger("Takeoff");
    }
    
    public void DiscoBtn()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<SettingsMenu>().Disco();
    }
    
    public void BtnSound()
    {
        FindObjectOfType<AudioManager>().Play("Button");
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<AudioManager>().StopPlaying("Menu");
        Application.Quit();
    }
}
