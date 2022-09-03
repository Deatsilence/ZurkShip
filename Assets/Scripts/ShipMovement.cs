using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody.drag = 2;
    }

    // Update is called once per frame
    void Update()
    {
       
        if ((Input.GetKey("w") || Input.GetKey("up")) && this.transform.position.z <= 100F)
            this.rigidbody.AddForce(0F, 0F, 128F);

        if ((Input.GetKey("s") || Input.GetKey("down")) && this.transform.position.z >= -190F)
            this.rigidbody.AddForce(0F, 0F, -128F);

        if ((Input.GetKey("a") || Input.GetKey("left")) && this.transform.position.x >= -250F)
            this.rigidbody.AddForce(-128F, 0F, 0F);

        if ((Input.GetKey("d") || Input.GetKey("right")) && this.transform.position.x <= 150F)
            this.rigidbody.AddForce(128F, 0F, 0F);

    }
}
