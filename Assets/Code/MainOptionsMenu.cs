using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainOptionsMenu : MonoBehaviour
{
    public NewAudioManager newAudioManager;
    public void volumeSettingsMenu()
    {
        NewAudioManager.Instance.PlaySFX("Button Click");        
    }

    public void graphicsSettingsMenu()
    {
        NewAudioManager.Instance.PlaySFX("Button Click");
    }

    public void backButton()
    {  
        NewAudioManager.Instance.PlaySFX("Button Click");
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
