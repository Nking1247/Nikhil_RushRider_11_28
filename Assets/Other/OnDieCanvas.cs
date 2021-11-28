using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class OnDieCanvas : MonoBehaviour, IUnityAdsListener
{
    // Start is called before the first frame update
    GameObject player;
    public Canvas adCanvas;
    [SerializeField] Image radial;
    [SerializeField] Text count;
    string placement = "SecondChance";
    string system;

    bool pauseTimer = false;
    bool test;

    int ranOnce = 0;
    float i;

    void Awake()
    {

#if UNITY_EDITOR
        test = false;
        system = "4221960";
#endif

#if UNITY_WEBGL
        test = false;
        system = "4221960";
#endif

#if UNITY_IOS
        test = true;
        system = "4221960";
        placement = "Rewarded_iOS";
#endif

#if UNITY_EDITOR
        test = true;
        system = "4221961";
        placement = "Rewarded_Android";
#endif



    }

    void Start()
    {
        
        Advertisement.AddListener(this);
        player = GameObject.FindGameObjectWithTag("Player"); 
        adCanvas.gameObject.SetActive(false);
        ranOnce = 0;
        Debug.Log("I started");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > i && ranOnce == 2)
        {
            ranOnce++;
        }
        if (!player.GetComponent<PlayerMovement>().notDead && player.GetComponent<PlayerMovement>().canAdAgain)
        {
            if (ranOnce == 0)
            {
                adCanvas.gameObject.SetActive(true);
                ranOnce++;
            }
            
            

            if (!pauseTimer)
            {
                radial.fillAmount -= (Time.deltaTime / 5);
                
            }
            

            int countText = (int) (radial.fillAmount * 5f) + 1;
            count.text = countText.ToString("0");
            if (radial.fillAmount == 0)
            {
                adCanvas.gameObject.SetActive(false);
                SceneManager.LoadScene("MainMenu");
            }
            
        }
        else if (!player.GetComponent<PlayerMovement>().notDead && !player.GetComponent<PlayerMovement>().canAdAgain && ranOnce == 3)
        {
            PlayerPrefs.Save();
            adCanvas.gameObject.SetActive(false);
            SceneManager.LoadScene("MainMenu");
            
        }


    }


    public void runAd()
    {
        Advertisement.Initialize(system, test);
        pauseTimer = true;
        new WaitForSeconds(2);

        if (Advertisement.IsReady(placement))
        {
                
                Advertisement.Show(placement);
              
        }
       
        
        
        
    }

    public void OnUnityAdsReady(string placementId)
    {
        
    }

    public void OnUnityAdsDidError(string message)
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnUnityAdsDidStart(string placementId)
    {
       
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            Debug.Log("I should have restarted");
            if (adCanvas != null)
            {
                adCanvas.gameObject.SetActive(false);
            }

            player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<PlayerMovement>().RunAgain();

            if (ranOnce == 1)
            {
                ranOnce++;
                i = Time.time + .5f;
            }
            
           
             
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
