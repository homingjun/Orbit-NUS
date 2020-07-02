﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    private string CurrScene;

    public static bool IsMuted = false;

    private void Start()
    {
        AudioManager.LastBGM = Random.Range(1, 4); //Edit max when # of BGM change
    }

    public void Paused()
    {
        Time.timeScale = 0;
    }

    public void UnPaused()
    {
        Time.timeScale = 1;
    }

    public void Mute()
    {
        IsMuted = true;
        FindObjectOfType<AudioManager>().StopPlaying("Menu");
        FindObjectOfType<AudioManager>().StopLast();
    }

    public void UnMute()
    {
        IsMuted = false;
        CurrScene = SceneManager.GetActiveScene().name;
        if (CurrScene == "Main Menu")
            FindObjectOfType<AudioManager>().Play("Menu");
        else
            NextTrack();
    }

    public void NextTrack()
    {
        int Number = AudioManager.LastBGM;
        Number += 1;
        if (Number > 3) //Edit when # of BGM change
            Number = 1;
        AudioManager.LastBGM = Number;
        FindObjectOfType<AudioManager>().Play("BGM" + Number);
    }

    public void ExitToMain()
    {
        UnPaused();
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<AudioManager>().StopLast();
        FindObjectOfType<AudioManager>().Play("Menu");
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
}