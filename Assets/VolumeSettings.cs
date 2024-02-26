using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;

    public void ToggleMusic()
    {
        NewAudioManager.Instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        NewAudioManager.Instance.ToggleSFX();
    }

    public void MusicVolume()
    {
        NewAudioManager.Instance.MusicVolume(_musicSlider.value);
    }

    public void SFXVolume()
    {
        NewAudioManager.Instance.SFXVolume(_sfxSlider.value);
    }
}
