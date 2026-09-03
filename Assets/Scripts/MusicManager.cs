using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    [SerializeField] AudioSource backgroundMusic;  // Reference to the background music AudioSource
    private bool muted = false;
    public static MusicManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
        }
        Load();
        UpdateButtonIcon();
        backgroundMusic.mute = muted;  // Mute or unmute the background music based on the state
    }

    public void OnButtonPress()
    {
        muted = !muted;  // Toggle the muted state
        backgroundMusic.mute = muted;  // Mute or unmute the background music
        Save();
        UpdateButtonIcon();
    }

    public void UpdateButtonIcon()
    {
        if (muted == false)
        {
            soundOnIcon.enabled = true;   // Show sound on icon
            soundOffIcon.enabled = false; // Hide sound off icon
        }
        else
        {
            soundOnIcon.enabled = false;  // Hide sound on icon
            soundOffIcon.enabled = true;  // Show sound off icon
        }

        

    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
