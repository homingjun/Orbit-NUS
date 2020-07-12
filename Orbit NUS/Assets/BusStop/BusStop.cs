﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BusStop : MonoBehaviour
{
    public bool isInRange;
    public bool isUIOpen = false;
    public KeyCode interactKey;
    public GameObject BusStopUI;
    public GameObject LoadingScreen;
    public Slider slider;

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                if (isUIOpen == false)
                {
                    OpenBusStopUI();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    public void OpenBusStopUI()
    {
        isUIOpen = true;
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<DontDestroyCanvas>().Hide();
        BusStopUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseBusStopUI()
    {
        isUIOpen = false;
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<DontDestroyCanvas>().Show();
        BusStopUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void BtnSound()
    {
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void BusStopSelect(Object scene)
    {
        CloseBusStopUI();
        SceneLoad.prevScene = null;
        StartCoroutine(LoadScreen(scene.name));
        
    }

    IEnumerator LoadScreen(string sceneName)
    {
        float duration = 2f;
        float timer = 0f;

        LoadingScreen.SetActive(true);

        while (timer <= 1f)
        {
            slider.value = timer;
            timer += Time.deltaTime / duration;
            yield return null;
        }

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }


}
