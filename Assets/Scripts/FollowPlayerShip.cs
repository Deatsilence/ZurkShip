using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerShip : MonoBehaviour
{
    public Transform spaceShip;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(spaceShip.position.x, spaceShip.position.y + 30, spaceShip.position.z + 12.3F);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(spaceShip.position.x, spaceShip.position.y + 30, spaceShip.position.z + 12.3F);
    }
}
