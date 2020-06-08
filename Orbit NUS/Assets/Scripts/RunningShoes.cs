using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RunningShoes : MonoBehaviour
{
    public KeyCode interactKey;
    public UnityEvent interactionAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            interactionAction.Invoke();
        }
    }
}
