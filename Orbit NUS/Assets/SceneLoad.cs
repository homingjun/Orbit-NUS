using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public int left_x, left_y, right_x, right_y;
    public GameObject left;
    public GameObject right;
    private GameObject player;
    public static string prevScene;
    public string leftScene, rightScene;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if (prevScene == leftScene)
        {
            player.transform.position = new Vector3(left.transform.position.x + left_x, left.transform.position.y + left_y, left.transform.position.z);
        }
        else if (prevScene == rightScene)
        {
            player.transform.position = new Vector3(right.transform.position.x + right_x, right.transform.position.y + right_y, right.transform.position.z);
        }
        prevScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
