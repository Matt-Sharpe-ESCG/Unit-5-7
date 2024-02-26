using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Audio Files
    public NewAudioManager newAudioManager;

    public TransitionManager transitionManager;

    private void Start()
    {
        NewAudioManager.Instance.PlayMusic("Menu Music");
    }

    public void playGame()
    {
        Debug.Log("Playing Game");
        transitionManager.playGameTrigger();
        NewAudioManager.Instance.PlaySFX("Button Click");
        NewAudioManager.Instance.musicSource.Stop();
    }

    public void openOptions()
    {
        NewAudioManager.Instance.PlaySFX("Button Click");
    }

    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();      
        NewAudioManager.Instance.PlaySFX("Button Click");       
    }  
}
