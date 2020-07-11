using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator GameTitle;
    public Animator RocketFly;
    public Animator BackG;

    private void Start()
    {
        GameTitle.SetTrigger("Title");
        RocketFly.SetTrigger("Takeoff");
        BackG.SetBool("Disco", SettingsMenu.DiscoMode);
    }
    
    public void DiscoBtn()
    {
        if (SettingsMenu.DiscoMode)
        {
            BackG.SetBool("Disco", false);
        }
        else
        {
            BackG.SetBool("Disco", true);
        }
        FindObjectOfType<SettingsMenu>().Disco();
    }
    
    public void BtnSound()
    {
        FindObjectOfType<AudioManager>().Play("Button");
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        Application.Quit();
    }
}
