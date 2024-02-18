using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class CompanyLogo : MonoBehaviour
{
    public VideoPlayer player;
    int waitForSeconds;

    public void Start()
    {
        waitForSeconds = 20;
    }

    public void Update()
    {
        waitForSeconds = waitForSeconds - 1;
        if (waitForSeconds == 0) 
        {
            menuLoad();
        }
    }

    public void menuLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
