using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteSound : MonoBehaviour
{

    [SerializeField] Button muteButton;
  
    [SerializeField] Sprite[] mutesSprites;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("mute"))
        {
            PlayerPrefs.SetInt("mute", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    private void Load()
    {
        AudioListener.volume = PlayerPrefs.GetInt("mute");
        if (AudioListener.volume == 1)
        {
            muteButton.image.sprite = mutesSprites[1];
        }
        else
        {
            muteButton.image.sprite = mutesSprites[0];
        }
        
    }
    

    public void MuteButtonOnClick()
    {
        if (PlayerPrefs.GetInt("mute") == 1)
        {
            PlayerPrefs.SetInt("mute", 0);
            AudioListener.volume = 0;
            muteButton.image.sprite = mutesSprites[0];

        }
        else
        {
            PlayerPrefs.SetInt("mute", 1);
            AudioListener.volume = 1;
            muteButton.image.sprite = mutesSprites[1];
        }
        PlayerPrefs.SetInt("mute", (int)AudioListener.volume);
    }

    
}
