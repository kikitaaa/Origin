using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luputon : MonoBehaviour
{
    public float health;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death(); // El personaje ha muerto
        }
    }
    private void Death()
    {
        Destroy(gameObject);
    }
}
