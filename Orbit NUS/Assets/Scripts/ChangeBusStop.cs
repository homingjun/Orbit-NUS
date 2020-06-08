using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBusStop : MonoBehaviour
{
    public bool isInteracted;

    public void ChngBusStop()
    {
        if (!isInteracted)
        {
            isInteracted = true;
            //Debug.Log("Bus Stop has been activated");
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                StartCoroutine(Tp());
            }
            else
            {
                StartCoroutine(Tp());
                SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
            }
        }
    }

    IEnumerator Tp()
    {
        Debug.Log("Preparing to teleport to bus stop in another scene");
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
        Debug.Log("Player has been teleported");
    }
}

