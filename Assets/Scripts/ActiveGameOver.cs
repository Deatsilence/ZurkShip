using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGameOver : MonoBehaviour
{
    public GameObject GameOverUI;

    // Update is called once per frame
    void Update()
    {
        if (EnemyShipMovements.EnemyPassedCount == 3)
        {
            //Time.timeScale = 0;
            GameOverUI.SetActive(true);

        }

    }
}
