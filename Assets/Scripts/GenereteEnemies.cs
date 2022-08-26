using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereteEnemies : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    private int spawnSecond = 0;
    private static int controlSamePoint = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnSecond < 3)
        {
            StartCoroutine(ExecuteAfterTime());       
            spawnSecond++;
        }
    }



    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(spawnSecond);

        // Code to execute after the delay
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        int randSpawnPointNew = Random.Range(0, spawnPoints.Length);
        
        if (randSpawnPoint == controlSamePoint)
        {
            if (controlSamePoint != randSpawnPointNew)
                randSpawnPoint = randSpawnPointNew;
        }
        controlSamePoint = randSpawnPoint;

     
        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }
}
