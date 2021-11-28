using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockSkin : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] List<Button> buttons;
    [SerializeField] List<Sprite> LockedImages;
    [SerializeField] List<Sprite> UnlockedImages;

    [SerializeField] Image Image;

    [SerializeField] MenuCoin CoinScript;



    void Start()
    {

        

        buttons[0].onClick.AddListener(Clicked0);
        buttons[1].onClick.AddListener(Clicked1);
        buttons[2].onClick.AddListener(Clicked2);
        buttons[3].onClick.AddListener(Clicked3);
        buttons[4].onClick.AddListener(Clicked4);
        buttons[5].onClick.AddListener(Clicked5);
        buttons[6].onClick.AddListener(Clicked6);
        buttons[7].onClick.AddListener(Clicked7);
        




        if (!PlayerPrefs.HasKey("YellowUnlocked"))
        {
            PlayerPrefs.SetInt("DefaultUnlocked", 1);
            PlayerPrefs.SetInt("YellowUnlocked", 0);
            PlayerPrefs.SetInt("GreenUnlocked", 0);
            PlayerPrefs.SetInt("RedUnlocked", 0);
            PlayerPrefs.SetInt("BlueBoxUnlocked", 0);
            PlayerPrefs.SetInt("YellowBoxUnlocked", 0);
            PlayerPrefs.SetInt("AIBike", 0);
            PlayerPrefs.SetInt("BlockUnlocked", 0);
            UpdateAll();
        }
        else
        {
            UpdateAll();
        }

    }

    // Update is called once per frame

    void UpdateAll()
    {
        buttons[0].GetComponent<Image>().sprite = UnlockedImages[0];
        if (PlayerPrefs.GetInt("YellowUnlocked") == 1)
        {
            buttons[1].GetComponent<Image>().sprite = UnlockedImages[1];
        }
        else
        {
            buttons[1].GetComponent<Image>().sprite = LockedImages[1];
        }

        if (PlayerPrefs.GetInt("GreenUnlocked") == 1)
        {
            buttons[2].GetComponent<Image>().sprite = UnlockedImages[2];
        }
        else
        {
            buttons[2].GetComponent<Image>().sprite = LockedImages[2];
        }

        if (PlayerPrefs.GetInt("RedUnlocked") == 1)
        {
            buttons[3].GetComponent<Image>().sprite = UnlockedImages[3];
        }
        else
        {
            buttons[3].GetComponent<Image>().sprite = LockedImages[3];
        }

        if (PlayerPrefs.GetInt("BlockUnlocked") == 1)
        {
            buttons[4].GetComponent<Image>().sprite = UnlockedImages[4];
        }
        else
        {
            buttons[4].GetComponent<Image>().sprite = LockedImages[4];
        }

        if (PlayerPrefs.GetInt("BlueBoxUnlocked") == 1)
        {
            buttons[5].GetComponent<Image>().sprite = UnlockedImages[5];
        }
        else
        {
            buttons[5].GetComponent<Image>().sprite = LockedImages[5];
        }

        if (PlayerPrefs.GetInt("YellowBoxUnlocked") == 1)
        {
            buttons[6].GetComponent<Image>().sprite = UnlockedImages[6];
        }
        else
        {
            buttons[6].GetComponent<Image>().sprite = LockedImages[6];
        }

        if (PlayerPrefs.GetInt("AIBike") == 1)
        {
            buttons[7].GetComponent<Image>().sprite = UnlockedImages[7];
        }
        else
        {
            buttons[7].GetComponent<Image>().sprite = LockedImages[7];
        }








    }

    void Clicked0()
    {
        Image.sprite = UnlockedImages[0];
        PlayerPrefs.SetInt("PlayerSkin", 0);
    }
    void Clicked1()
    {
        int number = 1;
        int price = 700;

        int currentCoins = PlayerPrefs.GetInt("Coins");

        string unlocked = "YellowUnlocked";
        if (PlayerPrefs.GetInt(unlocked) == 1)
        {
            PlayerPrefs.SetInt("PlayerSkin", number);
            Image.sprite = UnlockedImages[number];
        }
        else if (currentCoins >= price)
        {
            buttons[number].GetComponent<Image>().sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("Coins", currentCoins - price);
            CoinScript.UpdateCoin();
            Image.sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("PlayerSkin", number);
            PlayerPrefs.SetInt(unlocked, 1);

        }
    }
    void Clicked2()
    {
        int number = 2;
        int price = 1200;
        int currentCoins = PlayerPrefs.GetInt("Coins");
        string unlocked = "GreenUnlocked";
        if (PlayerPrefs.GetInt(unlocked) == 1)
        {
            PlayerPrefs.SetInt("PlayerSkin", number);
            Image.sprite = UnlockedImages[number];
        }
        else if (currentCoins >= price)
        {
            buttons[number].GetComponent<Image>().sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("Coins", currentCoins - price);
            CoinScript.UpdateCoin();
            Image.sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("PlayerSkin", number);
            PlayerPrefs.SetInt(unlocked, 1);

        }
    }
    void Clicked3()
    {
        int number = 3;
        int price = 1500;
        int currentCoins = PlayerPrefs.GetInt("Coins");
        string unlocked = "RedUnlocked";
        if (PlayerPrefs.GetInt(unlocked) == 1)
        {
            PlayerPrefs.SetInt("PlayerSkin", number);
            Image.sprite = UnlockedImages[number];
        }
        else if (currentCoins >= price)
        {
            buttons[number].GetComponent<Image>().sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("Coins", currentCoins - price);
            CoinScript.UpdateCoin();
            Image.sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("PlayerSkin", number);
            PlayerPrefs.SetInt(unlocked, 1);

        }
    }
    void Clicked4()
    {
        int number = 4;
        int price = 2000;
        int currentCoins = PlayerPrefs.GetInt("Coins");
        string unlocked = "BlueBoxUnlocked";
        if (PlayerPrefs.GetInt(unlocked) == 1)
        {
            PlayerPrefs.SetInt("PlayerSkin", number);
            Image.sprite = UnlockedImages[number];
        }
        else if (currentCoins >= price)
        {
            buttons[number].GetComponent<Image>().sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("Coins", currentCoins - price);
            CoinScript.UpdateCoin();
            Image.sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("PlayerSkin", number);
            PlayerPrefs.SetInt(unlocked, 1);

        }
    }
    void Clicked5()
    {
        int number = 5;
        int price = 3000;
        int currentCoins = PlayerPrefs.GetInt("Coins");
        string unlocked = "YellowBoxUnlocked";
        if (PlayerPrefs.GetInt(unlocked) == 1)
        {
            PlayerPrefs.SetInt("PlayerSkin", number);
            Image.sprite = UnlockedImages[number];
        }
        else if (currentCoins >= price)
        {
            buttons[number].GetComponent<Image>().sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("Coins", currentCoins - price);
            CoinScript.UpdateCoin();
            Image.sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("PlayerSkin", number);
            PlayerPrefs.SetInt(unlocked, 1);

        }
    }

    void Clicked6()
    {
        int number = 6;
        int price = 5000;
        int currentCoins = PlayerPrefs.GetInt("Coins");
        string unlocked = "AIBike";
        if (PlayerPrefs.GetInt(unlocked) == 1)
        {
            PlayerPrefs.SetInt("PlayerSkin", number);
            Image.sprite = UnlockedImages[number];
        }
        else if (currentCoins >= price)
        {
            buttons[number].GetComponent<Image>().sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("Coins", currentCoins - price);
            CoinScript.UpdateCoin();
            Image.sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("PlayerSkin", number);
            PlayerPrefs.SetInt(unlocked, 1);

        }
    }

    void Clicked7()
    {
        int number = 7;
        int price = 99999;
        int currentCoins = PlayerPrefs.GetInt("Coins");
        string unlocked = "BlockUnlocked";
        if (PlayerPrefs.GetInt(unlocked) == 1)
        {
            PlayerPrefs.SetInt("PlayerSkin", number);
            Image.sprite = UnlockedImages[number];
        }
        else if (currentCoins >= price)
        {
            buttons[number].GetComponent<Image>().sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("Coins", currentCoins - price);
            CoinScript.UpdateCoin();
            Image.sprite = UnlockedImages[number];
            PlayerPrefs.SetInt("PlayerSkin", number);
            PlayerPrefs.SetInt(unlocked, 1);
        }




    }
}
