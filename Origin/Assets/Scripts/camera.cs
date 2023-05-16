using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform playerTransform;

    private Vector3 playerposition;

    void Start()
    {
        playerposition = transform.position - playerTransform.position;
    }


    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x + playerposition.x, transform.position.y, transform.position.z); //sigue a Kai solo en el eje x
    }
}
