using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    public KeyCode interactKey;

    /*private static bool PlayerExists;

    void Start()
    {
        if(!PlayerExists)
        {
            PlayerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }*/



    Vector2 movement; // Vector2 refers to x and y planes
    Vector2 lookDirection;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(interactKey))
        {
            moveSpeed = 10f;
        }
        if (movement.x > 0)
        {
            animator.SetFloat("Direction", 0);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        else if (movement.x < 0)
        {
            animator.SetFloat("Direction", 1);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        else if (movement.y > 0)
        {
            animator.SetFloat("Direction", 2);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        else if (movement.y < 0)
        {
            animator.SetFloat("Direction", 3);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        else
        {
            animator.SetFloat("Speed", movement.sqrMagnitude);  
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
