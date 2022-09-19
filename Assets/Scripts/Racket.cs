using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Movment Speed
    public float speed = 150;
    void FixedUpdate ()
    {
        // Get Horizontal Input
        float h = Input.GetAxisRaw("Horizontal");
        // Set Velocity (movment direction * speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
