using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float period = 2f;
    //private float nextActionTime = 0.0f;


    //Camera.main.backgroundColor = Color.cyan;
    /*
    

    [SerializeField]
    float duration;

    float t = 0f;
    Color color1, color2;

    void Start() {
        color1 = new Color(167f/255f, 255f/255f, 237f/255f);
        color2 = new Color(21f/255f,19f/255f,39f/255f);
    }

    void Update() {
        Color color = Color.Lerp(color1, color2, t);
        t += Time.deltaTime / duration;
        Camera.main.backgroundColor = color;
        
        
    }
    */
    public float every;   //The public variable "every" refers to "Lerp the color every X"
    float colorstep;
    Color[] colors = new Color[6]; //Insert how many colors you want to lerp between here, hard coded to 4
    int i = 0;
    Color lerpedColor = new Color(167f/255f, 255f/255f, 237f/255f);  //This should optimally be the color you are going to begin with

    void Start () {

        //In here, set the array colors you are going to use, optimally, repeat the first color in the end to keep transitions smooth

        colors [0] = new Color(167f/255f, 255f/255f, 237f/255f);
        colors [1] = new Color(95f/255f, 205f/255f, 228f/255f);
        colors [2] = new Color(90f/255f, 161f/255f, 238f/255f);
        colors [3] = new Color(65f/255f, 124f/255f, 205f/255f);
        colors [4] =  new Color(21f/255f,19f/255f,39f/255f);
        colors [5] =  new Color(0,0,0);

    }


// Update is called once per frame
    void Update () {
        
        if (colorstep < every) { //As long as the step is less than "every"
            lerpedColor = Color.Lerp (colors[i], colors[i+1], colorstep);
            this.GetComponent<Camera> ().backgroundColor = lerpedColor;
            colorstep +=0.005f;  //The lower this is, the smoother the transition, set it yourself
        } else { //Once the step equals the time we want to wait for the color, increment to lerp to the next color

            colorstep = 0;

            if (i < (colors.Length - 2)){ //Keep incrementing until i + 1 equals the Lengh
                i++;
            }
            else { //and then reset to zero
                i=5;
            }
        }
    }

}
