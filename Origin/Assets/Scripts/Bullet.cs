using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float maxTime = 5;
    private float currentTime = 0;
    private List<string> nombres;

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
    }
}
