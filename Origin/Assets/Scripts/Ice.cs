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

    private void OnTriggerEnter2D(Collider2D other)
    {

        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
