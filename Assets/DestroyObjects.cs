using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HOLAAAAA");
        Destroy(other.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.collider.gameObject);
    }
}
