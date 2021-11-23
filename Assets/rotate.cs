using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame 
    public float rotation = -90;
    void Start()
    {

        transform.Rotate(0.0f, 0.0f, rotation, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
