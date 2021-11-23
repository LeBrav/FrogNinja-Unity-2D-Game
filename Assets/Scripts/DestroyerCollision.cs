using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject camera = GameObject.Find("Player");
        PlayerMovement playerScript = camera.GetComponent<PlayerMovement>();
        int points = playerScript.m_Points;
        if (points > Highscore.estatjoc.puntuacioMax) {
		
            Highscore.estatjoc.puntuacioMax = points;
            Highscore.estatjoc.Guardar ();

        }
        Debug.Log("DEAD");
        //GameObject camera2 = GameObject.Find("Main Camera");
        //camera2.GetComponent<AddManager>().ShowAdd();

        SceneManager.LoadScene("main");
    }
}