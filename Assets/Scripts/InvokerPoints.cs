using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokerPoints : MonoBehaviour
{
    public GameObject[] obj;

    public float tiempoMin = 2f;
    public float tiempoMax = 5.5f;



    private void Start()
    {
        Generar();
    }


    void Generar() {
        Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
        float time = Random.Range(tiempoMin, tiempoMax);
        Invoke ("Generar", time);
       
        
    }
}
