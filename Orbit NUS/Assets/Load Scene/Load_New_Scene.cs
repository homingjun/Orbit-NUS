using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_New_Scene : MonoBehaviour
{
    public string scene;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }
}
