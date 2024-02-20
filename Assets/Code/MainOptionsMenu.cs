using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOptionsMenu : MonoBehaviour
{
    public AudioManager audioManager;
   

    public void volumeSettingsMenu()
    {
        audioManager.Play("Button Click");
        
    }

    public void graphicsSettingsMenu()
    {
        audioManager.Play("Button Click");
        
    }

    public void backButton()
    {
        audioManager.Play("Button Click");
        
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
