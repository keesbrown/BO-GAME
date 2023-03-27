using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of player movement
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Gets horizontal input
        Vector2 movement = new Vector2(moveHorizontal, 0f);
        rb.velocity = movement * speed; // Moves the player horizontally based on input

        // Flips the player's sprite based on movement direction
        if (moveHorizontal > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (moveHorizontal < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
}



