using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xuongrong : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;
    public int speed;
    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();   

    }

    private void FixedUpdate()
    {
        Move();
            
    }
    private void Move()
    {
        rb.velocity = Vector3.left * speed;

    }
}
