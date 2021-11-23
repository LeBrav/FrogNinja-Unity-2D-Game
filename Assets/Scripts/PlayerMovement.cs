using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float m_JumpForce;
    public float m_HorizontalForce;
    
    private Rigidbody2D m_Rigidbody2D;
    private Animator m_Animator;
    private bool m_JumpRight;
    private bool m_JumpLeft;
    public Text m_PointsText;

    public AudioClip m_Sound;
    public AudioClip m_Sound2;

    public int m_Points = 0;
    private float nextActionTime = 0.0f;
    public float period = 1f;
    
    private float nextActionTime2 = 0.0f;
    private float period2 = 0.05f;
    public void JumpRight()
    {
        m_Animator.SetBool("IsFalling", false);
        m_Animator.SetBool("IsJumping", true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(m_Sound,0.3f);
        transform.localScale = new Vector3(5.0f, 5.0f, 1.0f);
        m_Rigidbody2D.velocity = Vector2.zero;
        m_Rigidbody2D.AddForce(Vector2.up*m_JumpForce);
        m_Rigidbody2D.AddForce(Vector2.right*m_HorizontalForce);
    }
    public void JumpLeft()
    {
        m_Animator.SetBool("IsFalling", false);
        m_Animator.SetBool("IsJumping", true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(m_Sound2,0.3f);
        transform.localScale = new Vector3(-5.0f, 5.0f, 1.0f);
        m_Rigidbody2D.velocity = Vector2.zero;
        m_Rigidbody2D.AddForce(Vector2.up*m_JumpForce);
        m_Rigidbody2D.AddForce(Vector2.left*m_HorizontalForce);
    }
    private void FixedUpdate()
    {
        m_PointsText.text = m_Points.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        m_Animator = GetComponent<Animator>();
        nextActionTime = Time.time;
        nextActionTime2 = Time.time;

        m_Points = 0;
        
    }


    // Update is called once per frame
    void Update()
    {
        
        
        if (Time.time > nextActionTime ) {
            m_Points += 1;
            nextActionTime += period;
        }

        if (Time.time > nextActionTime2)
        {
            if (m_Rigidbody2D.velocity.y == 0)
            {
                m_Animator.SetBool("IsJumping", false);
                m_Animator.SetBool("IsFalling", false);
            }
                
            if (m_Rigidbody2D.velocity.y < 0)
                m_Animator.SetBool("IsFalling", true);
            
            nextActionTime2 += period2;
        }

        

        //m_PointsText.text = m_Points.ToString();
        /*
        if (Physics2D.Raycast(transform.position, Vector2.down, 1f))
        {
            m_NumJumps = 2;
            Debug.Log("True");
        }
        
        if(m_JumpLeft||m_JumpRight)
        {

            Jump();
            m_JumpLeft = false;
            m_JumpRight = false;

        }
        */

    }
    
    private void Jump()
    {
        m_Rigidbody2D.velocity = Vector2.zero;
        if (m_JumpLeft)
        {
            m_Rigidbody2D.AddForce(Vector2.up*m_JumpForce);
            m_Rigidbody2D.AddForce(Vector2.left*m_HorizontalForce);
        }
        else
        {
            m_Rigidbody2D.AddForce(Vector2.up*m_JumpForce);
            m_Rigidbody2D.AddForce(Vector2.right*m_HorizontalForce);
        }
    }
}
