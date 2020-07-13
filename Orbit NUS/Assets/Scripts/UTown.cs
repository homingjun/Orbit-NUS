using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UTown : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        UTownMusic();
    }
    public void UTownMusic()
    {
        FindObjectOfType<AudioManager>().StopAll();
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
        FindObjectOfType<AudioManager>().StopAll();
        FindObjectOfType<SettingsMenu>().NextTrack();
    }

}
