using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    public AudioClip damageSound;
    [Range(0, 1)]
    public float damageVolume;
    

    private bool isWithinShield = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
        
            Kai player = collision.gameObject.GetComponent<Kai>();
            if (player != null)
            {
                if (!isWithinShield)
                {
                    player.TakeDamage(10); // O la cantidad de daño que desees
                    Debug.Log("-10 de salud");
                    AudioManager.instance.PlayAudio(damageSound, damageVolume);
                    
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shield"))
        {
            isWithinShield = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shield"))
        {
            isWithinShield = false;
        }
    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class HitEnemy : MonoBehaviour
//{
//    public AudioClip damageSound;
//    [Range(0, 1)]
//    public float damageVolume;
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.gameObject.CompareTag("Player"))
//        {
//            Kai player = collision.gameObject.GetComponent<Kai>();
//            if (player != null)
//            {
//                player.TakeDamage(10); // O la cantidad de daño que desees
//                Debug.Log("-10 de salud");
//                AudioManager.instance.PlayAudio(damageSound, damageVolume);
//            }
//        }
//    }

//}
