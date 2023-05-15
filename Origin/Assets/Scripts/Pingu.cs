using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pingu : MonoBehaviour
{

    public float speed;
    public bool isRight;

    public float timer;
    public float timeForChange = 4f;

    public float health;


    void Start()
    {
        timer = timeForChange;
    }


    void Update()
    {
        if (isRight == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            
        }
        if (isRight == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
         
        }

        //timer para que se de la vuelta
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeForChange;
            isRight = !isRight;
        }
    }
}
