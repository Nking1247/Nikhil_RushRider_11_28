using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuScore : MonoBehaviour
{
    int score;
    private void Awake()
    {
        UpdateScore();

    }

    public void UpdateScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", 0);
            score = PlayerPrefs.GetInt("HighScore");
        }

        gameObject.GetComponent<Text>().text = score.ToString();
    }
}
