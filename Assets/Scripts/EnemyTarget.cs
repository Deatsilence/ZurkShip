using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public float health = 50F;

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
