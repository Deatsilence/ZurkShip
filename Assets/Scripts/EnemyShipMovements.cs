using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMovements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().drag = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().AddForce(24F, 0F, 0F);
    }
}
