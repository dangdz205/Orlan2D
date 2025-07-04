using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class Dino : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator ani;
    public Image gameover;

    public int speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>(); 

    }
    private void Start()
    {
     
    }
    private void FixedUpdate()
    {
        Move();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("va cham !");
            gameover.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
        


    }
    private void Move()
    {
        if(Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * speed;



        }
        
    }

}
