using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public int puntuacioMax = 0;

    public static Highscore estatjoc;
    public Text m_Highscore;

    private String rutaArchivo;

    void Awake(){
        rutaArchivo = Application.persistentDataPath + "/datos.dat";
        if(estatjoc==null){
            estatjoc = this;
            DontDestroyOnLoad(gameObject);
        }else if(estatjoc!=this){
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        //m_Highscore = GameObject.Find("Highscore").GetComponent<Text>();

        Cargar();
        ActualizarMarcadorPuntos();
    }

    private void OnEnable()
    {
        Cargar();
        ActualizarMarcadorPuntos();
    }

    // Update is called once per frame
    void Update () {

    }
    public void ActualizarMarcadorPuntos()
    {
        m_Highscore.text = puntuacioMax.ToString();
    }
    void FixedUpdate () {
        ActualizarMarcadorPuntos ();
    }

    public void Guardar(){
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(rutaArchivo);

        DatosAGuardar2 datos = new DatosAGuardar2();
        datos.puntuacioMax = puntuacioMax;

        bf.Serialize(file, datos);

        file.Close();
    }

    void Cargar(){
        if(File.Exists(rutaArchivo)){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);

            DatosAGuardar2 datos = (DatosAGuardar2) bf.Deserialize(file);

            puntuacioMax = datos.puntuacioMax;

            file.Close();
        }else{
            puntuacioMax = 0;
        }
        /*
        GameObject camera = GameObject.Find("Player");
        PlayerMovement playerScript = camera.GetComponent<PlayerMovement>();
        playerScript.m_Points = 0;
        */
    }
}

[Serializable]
class DatosAGuardar2{
    public int puntuacioMax;
}