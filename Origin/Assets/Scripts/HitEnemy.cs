using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Kai player = collision.gameObject.GetComponent<Kai>();
            if (player != null)
            {
                player.TakeDamage(10); // O la cantidad de daño que desees
                Debug.Log("-10 de salud");
            }
        }
    }

    //        if (coll.CompareTag("Player"))
    //{
    //    print("Damage");
    //}



}
