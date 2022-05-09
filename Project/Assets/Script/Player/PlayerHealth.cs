using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0)
        {
            health = 0;
            if(GetComponent<PlayerMovement>())
            {
                GetComponent<PlayerMovement>().enabled = false;
            }
            else if(GetComponent<PlayerMovementYQ>())
            {
                GetComponent<PlayerMovementYQ>().enabled = false;
            }
            else if(GetComponent<Ex_PlayerMovement>())
            {
                GetComponent<Ex_PlayerMovement>().enabled = false;
            }
            else
            {

            }
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public int Damage(int amount)
    {
        
        health -= amount;
        UIHealthBar.instance.SetValue((float)health / 5.0f);
        return health;
    }
}
