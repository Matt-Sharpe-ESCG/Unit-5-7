using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Audio Files
    public AudioManager audioManager;

    public TransitionManager transitionManager;

    public void Start()
    {
        audioManager.Play("Main Menu Music");
    }

    public void playGame()
    {
        Debug.Log("Playing Game");
        transitionManager.playGameTrigger();
        audioManager.Play("Button Click");
    }

    public void openOptions()
    {
        audioManager.Play("Button Click");
    }

    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
        audioManager.Play("Button Click");
    }

    
}
