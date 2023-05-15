using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Kai>())
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
