using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Audio Files
    public AudioManager audioManager;

    public void playGame()
    {
        Debug.Log("Playing Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
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
