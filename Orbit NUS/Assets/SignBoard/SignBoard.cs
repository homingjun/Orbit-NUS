using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignBoard : MonoBehaviour
{
    public bool isInRange;
    public bool isUIOpen = false;
    public KeyCode interactKey;
    public GameObject SignboardUI;

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                if (isUIOpen == false)
                {
                    OpenSignboardUI();
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

    public void OpenSignboardUI()
    {
        isUIOpen = true;
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<DontDestroyCanvas>().Hide();
        SignboardUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseSignboardUI()
    {
        isUIOpen = false;
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<DontDestroyCanvas>().Show();
        SignboardUI.SetActive(false);
        Time.timeScale = 1;
    }
}
