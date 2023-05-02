using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luputon2: MonoBehaviour
{
    public int rutine;
    public float timer;
    public Animator anim;
    public int direction;
    public float speed_walk;
    public float speed_run;
    public GameObject target;
    public bool isAttacking;

    public float range_vision;
    public float range_attack;
    public GameObject range;
    public GameObject hit;
 

    private void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.Find("Kai");
        if (target == null)
        {
            Debug.LogError("No se ha encontrado el objeto 'Player'.");
        }
    }

    public void Behaviors()
    {
        if(Mathf.Abs(transform.position.x - target.transform.position.x) > range_vision && !isAttacking)
        {


            anim.SetBool("isRunning", false);
            timer += 1 * Time.deltaTime; //El cronometro suma 1 por cada frame
            if (timer >= 4)
            {
                rutine = Random.Range(0, 2);
                timer = 0;
            }

            switch (rutine)
            {
                case 0:
                    anim.SetBool("isWalking", false);
                    break;
                case 1:
                    direction = Random.Range(0, 2);
                    rutine++;
                    break;
                case 2:
                    switch (direction)
                    {
                        case 0:
                            transform.rotation = Quaternion.Euler(0, 180, 0);
                            transform.Translate(Vector3.left * speed_walk * Time.deltaTime);

                            break;

                        case 1:
                            transform.rotation = Quaternion.Euler(0, 0, 0);
                            transform.Translate(Vector3.left * speed_walk * Time.deltaTime);
                            break;
                    }
                    anim.SetBool("isWalking", true);
                    break;

            }


        }

        else
         {
            if (Mathf.Abs(transform.position.x - target.transform.position.x) > range_attack && !isAttacking)
            {
                if (transform.position.x < target.transform.position.x)
                {
                    anim.SetBool("isWalking", false);
                    anim.SetBool("isRunning", true);
                    transform.Translate(Vector3.left * speed_run * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    anim.SetBool("isAttacking", false);
                }
                else
                {
                    anim.SetBool("isWalking", false);
                    anim.SetBool("isRunning", true);
                    transform.Translate(Vector3.left * speed_run * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    anim.SetBool("isAttacking", false);
                }
            }
            else
            {
                if (!isAttacking)
                {
                    if(transform.position.x < target.transform.position.x)
                    {
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                    }
                    anim.SetBool("isWalking", false);
                    anim.SetBool("isRunning", false);
                }
            }


        }


    }

    public void Final_anim()
    {
        anim.SetBool("isAttacking", false);
        isAttacking = false;
        range.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void ColliderWeaponTrue()
    {
        hit.GetComponent<BoxCollider2D>().enabled = true;
    }
    public void ColliderWeaponFalse()
    {
        hit.GetComponent<BoxCollider2D>().enabled = false;
    }
    void Update()
    {
        Behaviors();
    }
}
