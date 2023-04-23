using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luputon1 : MonoBehaviour
{
    public float health;
    public Transform player;
    public float chaseDistance = 5f;
    public float speed = 5f;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
  
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < chaseDistance)
        {
            transform.LookAt(player);
            animator.SetBool("isRunning", true);
  
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isRunning", false);
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
    private void Death()
    {
        Destroy(gameObject);
    }
}
