using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = .5f;

    private void Start()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        PlayerControl.isLoading = true;
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        PlayerControl.isLoading = false;
    }
}
