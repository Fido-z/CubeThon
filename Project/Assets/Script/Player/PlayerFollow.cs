using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public GameObject camera;
    public float rotateSpeed = 0.5f;

    void Update()
    {
        transform.position = player.position + offset;
        //rotateView();
    }

    void rotateView()
    {
        transform.RotateAround(player.position, Vector3.up, rotateSpeed * Input.GetAxis("Mouse X"));
        offset = transform.position - player.position;
    }
}
