using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereteEnemies : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

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
        yield return new WaitForSeconds(3F);

        //if (spawnSecond < 5)
        //{
            //Code to execute after the delay
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            int randSpawnPointNew = Random.Range(0, spawnPoints.Length);

            while (randSpawnPoint == controlSamePoint)
            {
                randSpawnPointNew = Random.Range(0, spawnPoints.Length);
                randSpawnPoint = randSpawnPointNew;
            }

            controlSamePoint = randSpawnPoint;

            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
            StartCoroutine(ExecuteAfterTime());
        //}

    }
}
