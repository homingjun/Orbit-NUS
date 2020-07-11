using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UTown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().StopLast();
        if (SettingsMenu.DiscoMode)
        {
            if (Random.Range(1, 11) == 2)
            {
                FindObjectOfType<AudioManager>().Play("UTown2");
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("UTown1");
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("UTown");
        }
    }

    public void StopMusic()
    {
        FindObjectOfType<AudioManager>().StopPlaying("DiscoUTown2");
        FindObjectOfType<AudioManager>().StopPlaying("DiscoUTown1");
        FindObjectOfType<AudioManager>().StopPlaying("UTown");
        FindObjectOfType<SettingsMenu>().NextTrack();
    }

}
