using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusStop : MonoBehaviour
{
    public bool isOpen;
    public Animator anim;

    public void OpenBusStop()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Bus Stop is now open");
            anim.SetBool("isOpen", isOpen);
        }
        else
        {
            isOpen = false;
            Debug.Log("Bus Stop is now closed");
            anim.SetBool("isOpen", isOpen);

        }
    }


}
