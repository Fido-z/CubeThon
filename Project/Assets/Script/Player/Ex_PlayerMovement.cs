using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    //public AudioSource audio;
    public float forwardForce = 500f;
    public float sideForce = 500f;
    public Joystick joystick;
    public float addF = 5f;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -30f)
        {
            Debug.Log("fall");
            FindObjectOfType<GameManager>().EndGame();
        }
        rb.AddForce(0, 0, addF);
        rb.AddForce(joystick.Horizontal * 700f * Time.deltaTime, 0, 0);
        //rb.AddForce(joystick.Horizontal * 700f * Time.deltaTime, 0, joystick.Vertical * 700f * Time.deltaTime);
    }
}
