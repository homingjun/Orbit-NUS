using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject BusStop;
    public GameObject Player;
    

    public void Teleporter()
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Tp());
        }
    }

    IEnumerator Tp()
    {
        Debug.Log("Preparing to teleport player");
        yield return new WaitForSeconds(1f);
        Player.transform.position = new Vector3(BusStop.transform.position.x, BusStop.transform.position.y, BusStop.transform.position.z);
        Debug.Log("Player has been teleported");
    }
}
