using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    //public GameObject Collectable;
    //public Text CollectText;
    public int score = 0;
    //public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();

        if (other.tag == "Player")
        {
            //Player player = other.GetComponent<player>();

            Debug.Log("collectable");
            score++;
            //CollectText.text = "Coins: " + score;
            Destroy(this.gameObject);
        }

    }
}
