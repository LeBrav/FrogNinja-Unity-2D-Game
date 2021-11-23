using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausebutton;
    [SerializeField] private GameObject scorepanel;
    [SerializeField] private GameObject camera;

    private bool IsMuted = false;
    
    public AudioClip otherClip;
    public AudioClip mainClip;
    public void Start()
    {
        Time.timeScale = 0f;
        Camera.main.GetComponent<AudioSource>().clip = otherClip;
        Camera.main.GetComponent<AudioSource>().Play();
    }

    public void Play()
    {
        pausebutton.SetActive(true);
        scorepanel.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        Camera.main.GetComponent<AudioSource>().clip = mainClip;
        Camera.main.GetComponent<AudioSource>().Play();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Mute()
    {

        AudioListener.pause = !AudioListener.pause;
        

        
    }


}
