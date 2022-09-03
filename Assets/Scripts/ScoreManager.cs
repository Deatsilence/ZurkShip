using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;

    public static int score = 0;
    public static int highscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
        if (score > highscore)
        {
            highscore++;
            highscoreText.text = "HIGHSCORE: " + highscore.ToString();
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
