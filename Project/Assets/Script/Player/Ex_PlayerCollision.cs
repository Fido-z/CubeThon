using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public Ex_PlayerMovement movement;
    public AudioSource collideAudio;
    void Start()
    {
        movement.enabled = true;
        Debug.Log("start");
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerHealth>().Damage(1);
            collideAudio.Play();
        }

        if (collisionInfo.collider.tag == "Hammer")
        {
            GetComponent<PlayerHealth>().Damage(1);
            collideAudio.Play();
        }

        if (collisionInfo.collider.tag == "Accelerate")
        {
            Debug.Log("accelerate");
            rb.AddForce(0, 0, 700);

        }
    }
}
