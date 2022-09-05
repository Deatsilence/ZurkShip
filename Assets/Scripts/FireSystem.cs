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
    public static float tempSpeed;
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
            PrizeTarget targetPrize = hit.transform.GetComponent<PrizeTarget>();

            if (target != null)
            {
                target.TakeDamage(damage);
                ScoreManager.score++;
                if (ScoreManager.score % 10 == 0 && ScoreManager.score != 0)
                {
                    EnemyShipMovements.shipSpeed += 2;
                    Debug.Log("speed: " + EnemyShipMovements.shipSpeed);
                }   
            }
            if (targetPrize != null)
            {
                Debug.Log("inside prize");
                targetPrize.TakeDamage(damage);
                tempSpeed = EnemyShipMovements.shipSpeed;
                EnemyShipMovements.shipSpeed = 12;
                Debug.Log("speed: " + EnemyShipMovements.shipSpeed);
            }

        }
    }
}
