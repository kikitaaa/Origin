using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leonix : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
