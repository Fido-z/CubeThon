using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectYQ : MonoBehaviour
{
    //public Rigidbody rb;
    public AudioSource audio;
    public int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            audio.Play();
            score++;
        }
    } 
}
