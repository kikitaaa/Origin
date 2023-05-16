using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orm : MonoBehaviour
{
    public int health = 100; // La salud de orm
    private Animator animator; 

    void Start()
    {
      
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        // Reduce la salud de orm
        health -= damage;

        // Si la salud de orm es 0 o menos, muere
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //animacion de muerte
        animator.SetBool("Die", true);

        // Se deastruye después de un tiempo
        //
        Destroy(gameObject, 1f);
    }
}

