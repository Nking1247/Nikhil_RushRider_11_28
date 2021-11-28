using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] Canvas pauseCanvas;
    [SerializeField] Button ButtonDEPause;
    // Start is called before the first frame update
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseCanvas.gameObject.SetActive(true);
       
        ButtonDEPause.enabled = false;
        
    }
    public void UnpauseGame()
    {
        Time.timeScale = 1f;
        pauseCanvas.gameObject.SetActive(false);
        ButtonDEPause.enabled = true;
    }

    public void GoHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
