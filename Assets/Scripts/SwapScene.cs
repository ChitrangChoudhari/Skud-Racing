using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    void Update()
    {
        AudioSource bg = GameObject.Find("BgMusic").GetComponent<AudioSource>();
        if (SceneManager.GetActiveScene().buildIndex == 4 ||
            SceneManager.GetActiveScene().buildIndex == 5 ||
            SceneManager.GetActiveScene().buildIndex == 6 ||
            SceneManager.GetActiveScene().buildIndex == 7)
        {
            if (bg.isPlaying)
            {
                bg.Stop(); // Stop the audio
            }
        }
        else
        {
            if (!bg.isPlaying)
            {
                bg.Play();
            }
        }
        
    }
}
