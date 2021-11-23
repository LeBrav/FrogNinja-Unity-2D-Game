using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home()
    {
        SceneManager.LoadScene("main");
        GameObject player = GameObject.Find("Player");
        PlayerMovement playerScript = player.GetComponent<PlayerMovement>();
        playerScript.m_Points = 0;
        Time.timeScale = 0f;
        
    }

}
