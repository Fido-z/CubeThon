using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public Transform player;
    public Text scoreText;
    //float score=100;
    public int totaltime = 150;
    private float intervaletime = 1;

    void Start()
    {
        scoreText.text = string.Format("{0:00}:{1:00}", (int)totaltime / 60, (float)totaltime % 60);

    }

    // Update is called once per frame
    void Update()
    {
        //score = player.position.z + 45;
        //score--;
        //Debug.Log(score);
        //scoreText.text = score.ToString("0");
        int M = (int)(totaltime / 60);
        float S = totaltime % 60;
        if (totaltime > 0)
        {
            intervaletime -= Time.deltaTime;
            if (intervaletime <= 0)
            {
                intervaletime += 1;
                totaltime--;
                scoreText.text = string.Format("{0:00}:{1:00}", M, S);
            }
        }

        if (totaltime <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
