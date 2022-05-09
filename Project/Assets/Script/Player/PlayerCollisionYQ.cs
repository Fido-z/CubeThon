using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionYQ : MonoBehaviour
{
    public PlayerMovementYQ movement;
    public Material iceBall;
    public Material ironBall;
    public GameObject plane;
    public Material wood;
    public Material stoneBall;
    public AudioSource collideAudio;

    private PlayerMovementYQ playerMovementYQ;
    public int textureIndex = 0;
    private MeshRenderer meshRenderer;

    void Awake()
    {
        playerMovementYQ = GetComponent<PlayerMovementYQ>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        //movement.enabled = true;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerHealth>().Damage(1);
            collideAudio.Play();

        }

        //Change texture when collide with the triggerButton.
        if(collisionInfo.collider.tag == "TriggerIce")
        {
            meshRenderer.material = iceBall;
            textureIndex = 2;
        }
        else if (collisionInfo.collider.tag == "TriggerIron")
        {
            
            meshRenderer.material = ironBall;
            textureIndex = 1;
        }
        else if (collisionInfo.collider.tag == "TriggerWood")
        {
            meshRenderer.material = wood;
            textureIndex = 0;
        }
        else if(collisionInfo.collider.tag == "TriggerStone")
        {
            meshRenderer.material = stoneBall;
            textureIndex = 3;
        }
        else
        {

        }
        
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        // Make player control hard if the texture of the ball is not ice.
        if (collisionInfo.collider.tag == "IcePlatform")
        {
            Debug.Log("IceBoard");
            if (textureIndex != 2)// Is not ice
            {
                Debug.Log("Sliding");
                GetComponent<PlayerMovement>().forwardForce = 3000f;
            }
           
        }

        if (collisionInfo.collider.tag == "IronTrack") // Is iron
        {
            Debug.Log("IronTrack");
            if (textureIndex == 1) // Is iron
            {
                Debug.Log("Place plane!");
                plane.SetActive(true);
            }
        }
        

        if (collisionInfo.collider.tag == "Accelerate")
        {
            Debug.Log("Accelerate");
            if (textureIndex == 0)// Is wood
            {
                playerMovementYQ.forwardForce = 500f;
            }
            else
            {
                playerMovementYQ.forwardForce = 50f;
            }

        }
    }

}
