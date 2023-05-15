using UnityEngine;

public class Shield : MonoBehaviour
{
    public float shieldDuration = 5f; // Duraci�n del escudo en segundos
    public float shieldStrength = 1f; // Fuerza del escudo (0-1)

    private float shieldTimer;

    private void Start()
    {
        shieldTimer = shieldDuration;
    }

    private void Update()
    {
        shieldTimer -= Time.deltaTime;

        if (shieldTimer <= 0f)
        {
            Destroy(gameObject); // Destruye el objeto del escudo cuando la duraci�n se agota
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Calcula el da�o reducido por el escudo
            float reducedDamage = collision.GetComponent<Luputon2>().damage * (1f - shieldStrength);

            // Aplica el da�o reducido al enemigo
            collision.GetComponent<Luputon2>().TakeDamage(reducedDamage);
        }
    }
}