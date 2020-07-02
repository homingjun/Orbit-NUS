using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignBoard : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public GameObject SignboardUI;

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                OpenSignboardUI();
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
        //FindObjectOfType<AudioManager>().Play("Button");
        //FindObjectOfType<DontDestroyCanvas>().Hide();
        SignboardUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseSignboardUI()
    {
        //FindObjectOfType<AudioManager>().Play("Button");
        //FindObjectOfType<DontDestroyCanvas>().Show();
        SignboardUI.SetActive(false);
        Time.timeScale = 1;
    }
}
