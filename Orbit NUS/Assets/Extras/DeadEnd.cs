using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEnd : MonoBehaviour
{
    public GameObject DeadEndUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DeadEndUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void CloseDeadEndUI()
    {
        DeadEndUI.SetActive(false);
        Time.timeScale = 1;
    }
}
