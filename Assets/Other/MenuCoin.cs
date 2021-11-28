using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCoin : MonoBehaviour
{
    int Coins;

    private void Awake()
    {
        UpdateCoin();
    }

    public void UpdateCoin()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            Coins = PlayerPrefs.GetInt("Coins");
        }
        else
        {
            PlayerPrefs.SetInt("Coins", 0);
            Coins = PlayerPrefs.GetInt("Coins");
        }

        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }
}
