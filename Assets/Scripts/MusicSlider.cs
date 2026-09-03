using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class MusicSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider slider;

    public void SetMusicVolume()
    {
        float volume = slider.value;
        mixer.SetFloat("music", Mathf.Log10(volume)*20);
    }
}
