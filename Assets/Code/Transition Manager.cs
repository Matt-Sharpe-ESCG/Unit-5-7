using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    // Animator
    public Animator animator;

    // Int Variable
    public int transitionTime = 1;

    // Update is called once per frame
    public void playGameTrigger()
    {
        StartCoroutine(playGame(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator playGame(int gameIndex)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(gameIndex);
    }

    public void loadMainMenu()
    {
        StartCoroutine(loadMenu(SceneManager.GetActiveScene().buildIndex));
    }

    IEnumerator loadMenu(int gameIndex)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(1);
    }
}
