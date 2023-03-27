using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    [SerializeField] private Transform meleeController;
    public float meleeRadius;
    public float Meleedamage;
    public float timetoattack;
    public float timetonextattack;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timetonextattack > 0)
        {
            timetonextattack -= Time.deltaTime;
        }
        if (Input.GetButtonDown("Fire1") && timetonextattack <= 0)
        {
            Attack();
            timetonextattack = timetoattack;
        }
    }
    public void Attack()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(meleeController.position, meleeRadius);
        foreach (Collider2D collider in objects)
        {
            if (collider.CompareTag("Enemy"))
            {
                collider.transform.GetComponent<Leonix>().TakeDamage(Meleedamage);
                Debug.Log("golpe");
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(meleeController.position, meleeRadius);
    }
}
