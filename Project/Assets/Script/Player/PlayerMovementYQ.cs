using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementYQ : MonoBehaviour
{

    public float forwardForce = 500f;
    public float sideForce = 500f;


    public Rigidbody rigidbody;
    public Transform agretctCamera;
    public float speed = 5f;
    public float rotateSpeed = 5f;

    public float minmouseY = -45f;
    public float maxmouseY = 45f;
    public float mousespeed = 1f;


    float RotationY = 0f;
    float RotationX = 0f;

    public float rotateHead;//相机方向
    public float headSpeed = 3f;//相机移动速度
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
        joystick = FindObjectOfType<Joystick>();

    }

    void Update()
    {

        //RotationX += agretctCamera.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mousespeed;
        //RotationY -= Input.GetAxis("Mouse Y") * mousespeed;
        //RotationY = Mathf.Clamp(RotationY, minmouseY, maxmouseY);
        //this.transform.eulerAngles = new Vector3(0, RotationX, 0);
        //agretctCamera.transform.eulerAngles = new Vector3(RotationY, RotationX, 0);
        //agretctCamera.transform.eulerAngles = new Vector3(0, RotationX, 0);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 addForce = new Vector3(0, 0, 0);

        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            addForce =  new Vector3(forwardForce, 0, 0);
            rigidbody.AddForce(addForce.x*Time.deltaTime,addForce.y*Time.deltaTime,addForce.z*Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            addForce =  new Vector3(-forwardForce, 0, 0);
            rigidbody.AddForce(addForce.x * Time.deltaTime, addForce.y * Time.deltaTime, addForce.z * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            addForce =  new Vector3(0, 0, forwardForce);
            rigidbody.AddForce(addForce.x * Time.deltaTime, addForce.y * Time.deltaTime, addForce.z * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            addForce =  new Vector3(0, 0, -forwardForce);
            rigidbody.AddForce(addForce.x * Time.deltaTime, addForce.y * Time.deltaTime, addForce.z * Time.deltaTime);
        }


        if (rigidbody.position.y < -70f)
        {
            Debug.Log("fall");
            FindObjectOfType<GameManager>().EndGame();
        }

        rigidbody.AddForce(joystick.Horizontal * 700f * Time.deltaTime, 0, joystick.Vertical * 700f * Time.deltaTime);
    }
}
