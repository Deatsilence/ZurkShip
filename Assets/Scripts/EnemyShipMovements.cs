using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMovements : MonoBehaviour
{
    public GameOverScript gameOver;
    public float shipSpeed = 24F;
    private int EnemyPassedCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().drag = 2;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(shipSpeed, 0F, 0F);

        if (gameObject.transform.position.x >= 550)
        {
            Destroy(gameObject);
            EnemyPassedCount++;
            //if(EnemyPassedCount==3)

        }
    }
    public void GameOver()
    {
        gameOver.Setup(ScoreManager.score);
    }
}
