using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level1score : MonoBehaviour
{
    public int score1;
    public Text s;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("score1"))
        {
            PlayerPrefs.SetInt("score1", 0);
        }
        else
        {
            score1 = PlayerPrefs.GetInt("score1");
        }
        s.text = "Best score: " + score1;
    }

    // Update is called once per frame
    void Update()
    {
        score1 = PlayerPrefs.GetInt("score1");
        s.text = "Best score: " + score1;
    }
}
