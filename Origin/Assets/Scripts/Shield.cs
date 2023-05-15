using UnityEngine;

public class Shield : MonoBehaviour
{
    public string jugadorTag = "Player";
    public string enemigoTag = "Enemy";
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(enemigoTag))
        {
            // Desactivar el comportamiento de ataque del enemigo
            Luputon2 enemy = other.GetComponent<Luputon2>();
            if (enemy != null)
            {
               // enemy.StopAttack();
            }
        }
    }

}
