using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator an;
    private Joystick js;
    public static bool isLoading = false;

    Vector2 movement;

    void Update()
    {
        if (isLoading == false && Input.touchCount > 0)
        {
            js = FindObjectOfType<Joystick>();
            if (js.Horizontal >= .2f)
            {
                movement.x = 1;
            }
            else if (js.Horizontal <= -.2f)
            {
                movement.x = -1;
            }
            else
            {
                movement.x = 0;
            }

            if (js.Vertical >= .2f)
            {
                movement.y = 1;
            }
            else if (js.Vertical <= -.2f)
            {
                movement.y = -1;
            }
            else
            {
                movement.y = 0;
            }
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
