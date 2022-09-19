using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // movment speed
    public float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    void OnCollisionEnter2D(Collision2D col) 
    {
        //if (col.gameObject.name)
    }
}
