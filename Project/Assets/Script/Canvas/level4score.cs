using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level4score : MonoBehaviour
{
    public int score4;
    public Text s;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("score4"))
        {
            PlayerPrefs.SetInt("score4", 0);
        }
        else
        {
            score4 = PlayerPrefs.GetInt("score4");
        }
        s.text = "Best score: " + score4;
    }

    // Update is called once per frame
    void Update()
    {
        score4 = PlayerPrefs.GetInt("score4");
        s.text = "Best score: " + score4;
    }
}