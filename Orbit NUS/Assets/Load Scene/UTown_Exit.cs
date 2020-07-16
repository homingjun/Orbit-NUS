using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UTown_Exit : MonoBehaviour
{
    public Object scene;
    public UTown UT;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            UT.StopMusic();
            SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
        }
    }
}
