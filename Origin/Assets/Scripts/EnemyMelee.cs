using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    [SerializeField] private Transform MeleeController;
    public float MeleeRadius;
    public float Meleedamage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Attack()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(MeleeController.position, MeleeRadius);
        foreach (Collider2D collider in objects)
        {
            if (collider.CompareTag("Player"))
            {
                collider.transform.GetComponent<Kai>().TakeDamage(Meleedamage);
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(MeleeController.position, MeleeRadius);
    }
}
