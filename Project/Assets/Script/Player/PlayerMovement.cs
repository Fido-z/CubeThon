using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    //public AudioSource audio;
    public float forwardForce = 500f;
    public float sideForce = 500f;
    public Joystick joystick;

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

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime);
        }

        if (rb.position.y < -30f)
        {
            Debug.Log("fall");
            FindObjectOfType<GameManager>().EndGame();
        }

        //rb.velocity = new Vector3(joystick.Horizontal * 15f, rb.velocity.y, joystick.Vertical * 15f);
        rb.AddForce(joystick.Horizontal * 700f * Time.deltaTime, 0, joystick.Vertical * 700f * Time.deltaTime);
    }
}
