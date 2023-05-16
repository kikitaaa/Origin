using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] icePrefabs;
    public float maxTime = 2f;
    private float currentTime;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {
            Instantiate(icePrefabs[Random.Range(0, icePrefabs.Length)], new Vector2(Random.Range(transform.position.x - transform.localScale.x / 2,
                transform.position.x + transform.localScale.x / 2), transform.position.y), Quaternion.identity);


            currentTime = 0;
        }
    }
}

