using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_New_Scene : MonoBehaviour
{
    public Object scene;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
        }
    }
}
