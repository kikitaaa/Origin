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
    public int health;
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
    }
    private void FixedUpdate()
    {
        // Usamos un Raycast para lanzar un rayo que detecte el contacto con el suelo.
        Vector2 RayCastOrigin = transform.position - new Vector3(0, GetComponent<Collider2D>().bounds.extents.y, 0);
        Physics2D.Raycast(RayCastOrigin, -Vector2.up, 0.1f);
    }
    private void ProcessMovement() 
    {
        float movhor = Input.GetAxisRaw("Horizontal"); //Si pulsamos los botones designados al Axis Horizontal, se inicia el movimiento del personaje.
        //Debug.Log(movhor);
        animator.SetBool("isWalking", movhor != 0);
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
        if (Input.GetButtonDown("Jump") && (onfloor || jumps > 0 && jumps < 2)) //Si pulsamos la tecla designada al "Jump", "onfloor" es true y el n�mero de saltos es menor que 2 el jugador podr� saltar.
        {
            jumps++;
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            onfloor = false;
            //  AudioManager.instance.PlayAudio(jumpclip, 1);
        }
    }
    public void Healing(int healvalue)
    {
        Heal(health + healvalue <= 100 ? healvalue : 100 - health);

    }

    public void SpeedMult(int amount)
    {
        velocity *= amount;
    }
    public void Heal(int amount)
    {
        health += amount;
    }
    public void TakeDamage(int damage) //El jugador toma el da�o que inflingen sus enemigos y resta su vida.
    {
        health -= damage;
        if (health <= 0)
        {
            Death(); // Si la salud del personaje llega a 0 se invoca el m�todo Death().
        }
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.collider.CompareTag("floor")) //Detectamos la colisión del player con el suelo.
        {
            onfloor= true; //Establece el booleano onfloor en true.
            jumps = 0; //Establece loss saltos a 0.
        }
        if (other.collider.CompareTag("bullet")) //Detewctamos la colisión de la bala con el player. 
        {
            Bullet bullet = other.gameObject.GetComponent<Bullet>(); // Accedemos al componente Bullet.
            if (bullet != null) //Comprobamos si bullet es diferente a null.
            {
                TakeDamage(bullet.damage); //Invocamos la función Take Damage con el daño asignado en Bullet.
            }
        }
    }

    public void Death()
    { 

    }
}
