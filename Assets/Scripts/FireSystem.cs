using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FireSystem : MonoBehaviour
{
    public float damage = 10F;
    public float range = 100F;
    ShipWeapon weaponLeft;
    ShipWeaponRight weaponRight;
    AudioSource audioSource;


    public Camera shipCam;

    // Start is called before the first frame update
    void Start()
    {
        weaponLeft = GetComponentInChildren<ShipWeapon>();
        weaponRight = GetComponentInChildren<ShipWeaponRight>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            weaponLeft.StartFiring();
            weaponRight.StartFiring();
            audioSource.Play();
            Fire();
        }
        //if (weaponLeft.isFaring && weaponRight.isFaring)
        //{
        //    weaponLeft.UpdateFiring(Time.deltaTime);
        //    weaponRight.UpdateFiring(Time.deltaTime);
        //    //Fire();
        //}

        weaponLeft.UpdateBullets(Time.deltaTime);
        weaponRight.UpdateBullets(Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            weaponLeft.StopFiring();
            weaponRight.StopFiring();
        }

    }

    public void Fire()
    {
        RaycastHit hit;

        if (Physics.Raycast(shipCam.transform.position, shipCam.transform.forward, out hit, range))
        {

            EnemyTarget target = hit.transform.GetComponent<EnemyTarget>();
            if (target != null)
            {
                target.TakeDamage(damage);
                Debug.Log(hit.transform.name + " " + target.health + " " + damage);
            }
        }
    }
}
