using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2score : MonoBehaviour
{
    public int score2;
    public Text s;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("score2"))
        {
            PlayerPrefs.SetInt("score2", 0);
        }
        else
        {
            score2 = PlayerPrefs.GetInt("score2");
        }
        s.text = "Best score: " + score2;
    }

    // Update is called once per frame
    void Update()
    {
        score2 = PlayerPrefs.GetInt("score2");
        s.text = "Best score: " + score2;
    }
}
