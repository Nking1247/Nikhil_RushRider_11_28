using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManage : MonoBehaviour
{
    bool City;

    private void Update()
    {
        
    }
    public void PlayCommand()
    {
        if (PlayerPrefs.HasKey("City"))
        {
           
            int cityBool = PlayerPrefs.GetInt("City");
            if (cityBool == 0)
            {
                SceneManager.LoadScene("HillyGame");
                Time.timeScale = 1f;
            }
            else
            {
                SceneManager.LoadScene("Game");
                Time.timeScale = 1f;
            }
            
        }
        else
        {
            PlayerPrefs.SetInt("City", 1);
            SceneManager.LoadScene("Game");
            Time.timeScale = 1f;
        }

        

    }

    public void HelpScene()
    {
        SceneManager.LoadScene("HelpScene");
    }

    public void LeaveHelpScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
