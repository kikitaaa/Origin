using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    public Animator anim;
    public Luputon2 enemy;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isAttacking", true);

            enemy.isAttacking = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

}
