using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCollision : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {

            Debug.Log("Player");
            if (player.GetComponent<PlayerCollisionYQ>().textureIndex == 3)
            {
                Debug.Log("Move");
                rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            }

        }
        else
        {
            Debug.Log("Stop");
            rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        }
    }


}
