using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScore : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    int highScore = 0;
    int score;
    int tenFrame;

    GameObject player;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", 0);
            highScore = PlayerPrefs.GetInt("HighScore");
        }

        highScoreText.text = "HIGH: " + highScore;

    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void FixedUpdate()
    {
        bool deadNot = player.GetComponent<PlayerMovement>().notDead;
        if (tenFrame >= 5 && deadNot)
        {
            score++;
            tenFrame = 0;
            scoreText.text = score.ToString();

        }
        else if (!deadNot)
        {
            
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
                PlayerPrefs.Save();

            }
            //enabled = false;
        }
        else
        {
            tenFrame++;
        }
        if (score > highScore)
        {
            highScoreText.text = "HIGH: " + score;
        }

        
        /*
        if (!player.GetComponent<PlayerMovement>().notDead)
        {
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
                PlayerPrefs.Save();
                
            }
        }
        */
    }

    private void OnDestroy()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            enabled = false;
        }
    }

}
