using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AddManager : MonoBehaviour
{

    #if UNITY_ANDROID
    private string gameId = "4442155";
    #endif

    bool testMode = true;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId,testMode);
    }

    public void ShowAdd()
    {
        while (!Advertisement.IsReady())
        {
            Debug.Log("wait");
        }
        Advertisement.Show();
        if (Advertisement.IsReady())
        {
            
            Advertisement.Show();
        }
        else
        {
            Debug.Log("add not ready");
        }
    }
}
