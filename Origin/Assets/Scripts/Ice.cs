using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ice : MonoBehaviour
{
   
    private float maxTime = 5f;
    private float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        maxTime = Random.Range(2, 6);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {
            Destroy(gameObject);
            currentTime = 0;
        }
    }

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
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Choque con player");
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
}
