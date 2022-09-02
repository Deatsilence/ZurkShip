using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMovements : MonoBehaviour
{
    public float shipSpeed = 24F;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().drag = 2;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(shipSpeed, 0F, 0F);

        if (gameObject.transform.position.x >= 450)
        {
            Destroy(gameObject);

            GenereteEnemies.spawnSecond--;
        }
    }
}
