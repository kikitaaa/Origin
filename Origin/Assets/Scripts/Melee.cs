using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    [SerializeField] private Transform meleeController;
    public float meleeRadius;
    public float Meleedamage;
    public float timetoattack;
    public float timetonextattack;
    private Animator animator;
    public AudioClip attackSound;
    [Range(0, 1)]
    public float attackVolume;
    public AudioClip luputonSound;
    [Range(0, 1)]
    public float luputonVolume;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if(timetonextattack > 0)
        {
            timetonextattack -= Time.deltaTime;
        }
        if (Input.GetButtonDown("Fire1") && timetonextattack <= 0)
        {
            Attack();
            timetonextattack = timetoattack;
            animator.SetBool("isAttacking", true);
            AudioManager.instance.PlayAudio(attackSound, attackVolume);
        }

    }
    public void Attack()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(meleeController.position, meleeRadius);
        foreach (Collider2D collider in objects)
        {
            if (collider.CompareTag("Enemy"))
            {
                collider.transform.GetComponent<Luputon2>().TakeDamage(Meleedamage);
                animator.SetBool("isAttacking", true);
                //animator.Play("Hurt");
                Debug.Log("golpe");
                AudioManager.instance.PlayAudio(luputonSound, luputonVolume);

            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(meleeController.position, meleeRadius);
    }
    public void StopAttack()
    {
        animator.SetBool("isAttacking", false);
    }

}
