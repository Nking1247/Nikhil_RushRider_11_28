using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinGrabber : MonoBehaviour
{
    public int coinAmount = 0;
    public Text coinText;
    int coinThisRun = 0;

    private void Awake()
    {
        coinAmount = PlayerPrefs.GetInt("Coins");
        UpdateText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            collision.gameObject.GetComponent<CoinRotate>().grabbed = true;
            coinAmount++;
            coinThisRun++;
            PlayerPrefs.SetInt("Coins", coinAmount);
            UpdateText();

        }
    }

    public void UpdateText()
    {
        coinText.text = coinThisRun.ToString();
    }

    private void OnDestroy()
    {
        PlayerPrefs.Save();
    }

    

}
