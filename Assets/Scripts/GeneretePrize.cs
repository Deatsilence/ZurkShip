using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneretePrize : MonoBehaviour
{
    public Transform[] spawnPointsPrizes;
    public GameObject prizePrefab;
    private static int controlSamePoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteAfterTime());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(15F);

        //if (spawnSecond < 5)
        //{
        //Code to execute after the delay
        if (EnemyShipMovements.shipSpeed == 12)
            EnemyShipMovements.shipSpeed = FireSystem.tempSpeed;

        int randSpawnPoint = Random.Range(0, spawnPointsPrizes.Length);
        int randSpawnPointNew = Random.Range(0, spawnPointsPrizes.Length);

        while (randSpawnPoint == controlSamePoint)
        {
            randSpawnPointNew = Random.Range(0, spawnPointsPrizes.Length);
            randSpawnPoint = randSpawnPointNew;
        }

        controlSamePoint = randSpawnPoint;

        Instantiate(prizePrefab, spawnPointsPrizes[randSpawnPoint].position, transform.rotation);
        StartCoroutine(ExecuteAfterTime());
        //}

    }
}
