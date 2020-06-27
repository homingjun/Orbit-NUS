using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Object scene;
    public GameObject player;
    

    public void ChngScene()
    {
        StartCoroutine(Tp());
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ChngScene();
        }
    }

    IEnumerator Tp()
    {
        

        SceneManager.LoadScene(scene.name, LoadSceneMode.Single);
       //SceneManager.MoveGameObjectToScene(player, SceneManager.GetSceneByName(scene.name));
        
        yield return new WaitForSeconds(1f);
       // Scene currentscene = SceneManager.GetActiveScene();
       // SceneManager.UnloadSceneAsync(currentscene);
    }
}

