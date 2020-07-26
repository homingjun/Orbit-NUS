using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    private string CurrScene;

    public static bool IsMuted = false;
    public static bool DiscoMode = false;
    public static bool IsPaused = false;
    public Joystick joystick;

    private void Start()
    {
        Screen.SetResolution(1600, 900, true);
        AudioManager.LastBGM = Random.Range(1, 5); //Edit max when # of BGM change
    }

    private void Update()
    {
        CurrScene = SceneManager.GetActiveScene().name;
        if (CurrScene == "Main Menu")
            joystick.gameObject.SetActive(false);
        else
            joystick.gameObject.SetActive(true);
    }

    public void Disco()
    {
        if (DiscoMode)
        {
            FindObjectOfType<AudioManager>().Play("Button");
            FindObjectOfType<AudioManager>().StopPlaying("DiscoMenu");
            DiscoMode = false;
            FindObjectOfType<AudioManager>().Play("Menu");
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("DiscoButton");
            FindObjectOfType<AudioManager>().StopPlaying("Menu");
            DiscoMode = true;
            FindObjectOfType<AudioManager>().Play("Menu");
        }
    }

    public void Paused()
    {
        Time.timeScale = 0;
        IsPaused = true;
    }

    public void UnPaused()
    {
        Time.timeScale = 1;
        IsPaused = false;
    }

    public void Mute()
    {
        IsMuted = true;
        FindObjectOfType<AudioManager>().StopAll();
    }

    public void UnMute()
    {
        IsMuted = false;   
        if (CurrScene == "Main Menu")
            FindObjectOfType<AudioManager>().Play("Menu");
        else if (CurrScene == "UTown")
            FindObjectOfType<UTown>().UTownMusic();
        else
            NextTrack();
    }

    public void NextTrack()
    {
        int Number = AudioManager.LastBGM;
        Number += 1;
        if (Number > 4) //Edit when # of BGM change
            Number = 1;
        AudioManager.LastBGM = Number;
        FindObjectOfType<AudioManager>().Play("BGM" + Number);
    }

    public void ExitToMain()
    {
        UnPaused();
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<AudioManager>().StopAll();
        FindObjectOfType<AudioManager>().Play("Menu");
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
}
