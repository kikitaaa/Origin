using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public int time = 0;
    private float currentTime = 0;
    public int damage;
    public AudioClip damageSound;
    [Range(0, 1)]
    public float damageVolume;

    void Update()
    {
        BulletPosition();
        DestroyShoot();
    }

    void BulletPosition()
    {
        transform.Translate(direction * speed * Time.deltaTime); //Posicion inicial de donde va a moverse la bala
    }
    void DestroyShoot()
    {
        currentTime += Time.deltaTime; //Pasado un determinado tiempo se autodestruyen las balas
        if (currentTime >= time)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Choque con player");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Kai player = collision.gameObject.GetComponent<Kai>();
            if (player != null)
            {
                player.TakeDamage(10); // O la cantidad de da�o que desees
                Debug.Log("-5 de salud");
                AudioManager.instance.PlayAudio(damageSound, damageVolume);
                Destroy(gameObject);
                Debug.Log("Choque con player");
            }
        }
    }
}
