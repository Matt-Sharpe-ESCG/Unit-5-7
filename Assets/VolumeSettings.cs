using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void masterVol(float masterVol)
    {
        audioMixer.SetFloat("volume", masterVol);
    }
}
