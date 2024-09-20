using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Vector2 direction = Vector2.right;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Collider>()!= null)
        {
            rb.velocity = Vector2.zero;
        }
    }
	
    
}
