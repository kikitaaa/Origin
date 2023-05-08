using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float maxTime = 5;
    private float currentTime = 0;
    private List<string> nombres;
    public GameObject[] hearts;
    private int life;

    private void Start()
    {
        // Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
        nombres = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            for (int i = 1; i <= 1; i += 1)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);


                {
                    nombres.Add(bullet.name);
                }

            }


            foreach (string b in nombres)
            {
                Debug.Log(b);

            }


            currentTime = 0;
        }

        if (life > 0)
        {
            life--;
        }
         else if (life < 1)
        {

        }
        else if (life < 2)
        {

        }
        else if (life < 3)
        {

        }
        else if (life < 4)
        {

        }
        else if (life < 5)
        {

        }
        else if (life < 6)
        {

        }
      }
    }
