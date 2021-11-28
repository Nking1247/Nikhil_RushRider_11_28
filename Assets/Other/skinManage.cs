using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skinManage : MonoBehaviour
{


    [SerializeField] Canvas box;
    [SerializeField] Canvas main;

    [SerializeField] Image Image;

    [SerializeField] List<Sprite> First;
    [SerializeField] List<GameObject> skins;

    [SerializeField]GameObject player;
    public Transform parent;

    [SerializeField] GameObject player2;
    public Transform parent2;

    [SerializeField] Camera mainCam;
    public bool city = true;



    private void Start()
    {
        if (PlayerPrefs.HasKey("City"))
        {
            int cityNumber = PlayerPrefs.GetInt("City");
            if (cityNumber == 1)
            {
                mainCam.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
            else
            {
                mainCam.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
        }

        if (PlayerPrefs.HasKey("PlayerSkin"))
        {
            Destroy(player);
            player = Instantiate(skins[PlayerPrefs.GetInt("PlayerSkin")], parent);
            Image.sprite = First[PlayerPrefs.GetInt("PlayerSkin")];

            Destroy(player2);
            player2 = Instantiate(skins[PlayerPrefs.GetInt("PlayerSkin")], parent2);
            Image.sprite = First[PlayerPrefs.GetInt("PlayerSkin")];
        }
        else
        {
            PlayerPrefs.SetInt("PlayerSkin", 0);
            Destroy(player);
            player = Instantiate(skins[PlayerPrefs.GetInt("PlayerSkin")], parent);
            Image.sprite = First[PlayerPrefs.GetInt("PlayerSkin")];

            Destroy(player2);
            player2 = Instantiate(skins[PlayerPrefs.GetInt("PlayerSkin")], parent2);
            Image.sprite = First[PlayerPrefs.GetInt("PlayerSkin")];
        }


        
    }


    public void boxrun()
    {
        box.gameObject.SetActive(true);
        main.gameObject.SetActive(false);
    }
    public void boxquit()
    {
        box.gameObject.SetActive(false);
        main.gameObject.SetActive(true);

        Destroy(player);
        player = Instantiate(skins[PlayerPrefs.GetInt("PlayerSkin")], parent);

        Destroy(player2);
        player2 = Instantiate(skins[PlayerPrefs.GetInt("PlayerSkin")], parent2);
    }

    public void ChangeToCity()
    {
        city = true;
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        PlayerPrefs.SetInt("City", 1);
    }
    public void ChangeToHill()
    {
        city = false;
        mainCam.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        PlayerPrefs.SetInt("City", 0);
    }

   /* public void Option1()
    {
        PlayerPrefs.SetInt("PlayerSkin", 0);
        Image.sprite = First[0];
    }
    public void Option2()
    {
        PlayerPrefs.SetInt("PlayerSkin", 1);
        Image.sprite = First[1];
    }
    public void Option3()
    {
        PlayerPrefs.SetInt("PlayerSkin", 2);
        Image.sprite = First[2];
    }
    public void Option4()
    {
        PlayerPrefs.SetInt("PlayerSkin", 3);
        Image.sprite = First[3];
    }

    public void Option5()
    {
        PlayerPrefs.SetInt("PlayerSkin", 4);
        Image.sprite = First[4];
    }

    */
}
