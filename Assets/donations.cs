using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donations : MonoBehaviour
{
   public void OpenURL()
     {
         Application.OpenURL("https://paypal.me/lebrav");
         Debug.Log("is this working?");
     }
}
