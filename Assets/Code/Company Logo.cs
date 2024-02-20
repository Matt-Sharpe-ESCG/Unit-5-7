using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class CompanyLogo : MonoBehaviour
{
    public TransitionManager transitionManager;

    void Start()
    {
        StartCoroutine(companyLogo());
    }

    IEnumerator companyLogo()
    {
        yield return new WaitForSeconds(3);

        transitionManager.loadMainMenu();
    }
}
