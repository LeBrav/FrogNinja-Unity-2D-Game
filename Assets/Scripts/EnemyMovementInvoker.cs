using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementInvoker : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period = 2f;

    public int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        nextActionTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x+direction*Time.deltaTime*2.5f,transform.position.y,transform.position.z);
        if (Time.time > nextActionTime ) {
            direction = (direction == 1)? direction = -1 : direction = 1;
            nextActionTime += period;
        }
    }
}
