using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    public float m_Speed;
    public GameObject generator;
    public GameObject generator2;
    public GameObject generatorHard;
    
    public GameObject invokerpoints;
    public GameObject invokerpoints2;
    
    public GameObject invokerpointsHard;
    public GameObject invokerpointsHard2;

    public GameObject invokerHardwall;
    public GameObject invokerHard2wall;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        m_Speed = 0;
        yield return new WaitForSeconds(2);
        m_Speed = 2;
        generator.SetActive(true);
        yield return new WaitForSeconds(58);
        Destroy(generator);
        Destroy(generator2);
        Destroy(invokerpoints);
        Destroy(invokerpoints2);
        yield return new WaitForSeconds(2);
        generatorHard.SetActive(true);
        invokerpointsHard.SetActive(true);
        invokerpointsHard2.SetActive(true);
        yield return new WaitForSeconds(2);
        invokerHardwall.SetActive(true);
        invokerHard2wall.SetActive(true);

    }


    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x,transform.position.y+m_Speed*Time.deltaTime,transform.position.z);

    }
}
