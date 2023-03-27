using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kai : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer rend;
    private Animator animator;
    public float velocity = 10f;
    public float jumpforce;
    public float maxheightofjump;
    private bool onfloor = false;
    public float health;
    public Slider healthbar;
    public float jumps = 0;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        ProcessMovement();
        ProcessJump();
        CheckHealth();
    }
    private void FixedUpdate()
    {
        Vector2 RayCastOrigin = transform.position - new Vector3(0, GetComponent<Collider2D>().bounds.extents.y, 0);
        Physics2D.Raycast(RayCastOrigin, -Vector2.up, 0.1f);

        //if (rb.velocity.y > maxheightofjump)
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, maxheightofjump);
        //}


    }
    private void ProcessMovement()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float movhor = Input.GetAxisRaw("Horizontal"); //Si pulsamos los botones designados al Axis Horizontal, se inicia el movimiento del personaje.
        rb.velocity = new Vector2(movhor * velocity, rb.velocity.y);

        if (movhor > 0)
        {
            rend.flipX = false;
        }
        else if (movhor < 0)
        {
            rend.flipX = true; //si el movhor es mayor que 0 el personaje gira.
        }
    }
    private void ProcessJump()
    {
        if (Input.GetButtonDown("Jump") && (onfloor || jumps > 0 && jumps < 2))
        {
            jumps++;
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            onfloor = false;
            //  AudioManager.instance.PlayAudio(jumpclip, 1);
        }
    }
   private void CheckHealth()
    {
        {
            healthbar.value = health;
        }

    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death(); // El personaje ha muerto
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("floor"))
        {
            onfloor= true;
            jumps = 0;
        }
    }
    public void Death()
    { 

    }
}
