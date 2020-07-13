using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator an;
    public static bool isLoading = false;

    Vector2 movement;

    void Update()
    {
        if (isLoading == false)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
        
        if (movement != Vector2.zero)
        {
            an.SetFloat("Horizontal", movement.x);
            an.SetFloat("Vertical", movement.y);
        }
        an.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
