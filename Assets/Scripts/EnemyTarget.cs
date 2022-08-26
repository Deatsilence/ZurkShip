using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public float health = 50F;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }



    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0F)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
