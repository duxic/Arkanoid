using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int number;
    public GameObject powerUp;
    
    void OnCollisionEnter2D(Collision2D collisionInfo) 
    {
        int number = Random.Range(0, 5);
        yield return 0;
        Destroy(gameObject);
    }
}
void Update() 
{
    if (number = 5)
    {
        Instantiate(powerUp, transform.position, transform.rotation);
    }
}
