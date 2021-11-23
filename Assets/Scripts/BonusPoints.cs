using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoints : MonoBehaviour
{
    public int bonusP;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject player = GameObject.Find("Player");
            PlayerMovement playerScript = player.GetComponent<PlayerMovement>();
            playerScript.m_Points+=bonusP;
            
        }
        Destroy(gameObject);
    }
}
