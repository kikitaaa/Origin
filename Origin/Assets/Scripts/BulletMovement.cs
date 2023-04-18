using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public int time = 0;
    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
}
