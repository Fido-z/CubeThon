using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public GameManager gameManager;
    public Text LifeText;
    public int life = 5;
    public GameObject Player;
    bool end = false;



    public void Update()
    {
        if (gameManager.gameHasEnded) 
        {
            end = true;
        }
        life = Player.GetComponent<PlayerHealth>().health;
        LifeText.text = "Life: " + life;
    }

    /*private void lifeSubtract()
    {
        life--;
        if(life <= 0)
        {
            Debug.Log("Dead");
            life = 0;
            gameManager.gameHasEnded = true;
        }
    }*/
}
