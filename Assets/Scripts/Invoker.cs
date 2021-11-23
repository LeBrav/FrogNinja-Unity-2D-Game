using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Invoker : MonoBehaviour
{

    public GameObject[] obj;
    public GameObject generator;
    public GameObject generator2;
    public float tiempoMin = 2f;
    public float tiempoMax = 5.5f;
    public int n_tries = 0;

    private float nextActionTime = 0.0f;
    public float period = 10f;

    private void Start()
    {
        nextActionTime = Time.time;
        
    }

    void OnEnable()
    {
        
        
        Generar();
    }

    private void Update()
    {
        if (n_tries < 5)
        {
            if (Time.time > nextActionTime ) {
                tiempoMax -= 0.5f;
                tiempoMin -= 0.1f;
                n_tries++;
                Debug.Log(n_tries);
                Debug.Log(tiempoMin);
                nextActionTime += period;
            }
        }
        
    }

    void setActivee()
    {
        generator.SetActive(true);
        generator2.SetActive(false);
    }
    void Generar() {
        Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
        float time = Random.Range(tiempoMin, tiempoMax);
        Invoke ("setActivee", time);
        //Invoke ("Generar", time);
        
        
    }


}