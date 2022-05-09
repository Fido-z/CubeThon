using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level5score : MonoBehaviour
{
    public int score5;
    public Text s;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("score5"))
        {
            PlayerPrefs.SetInt("score5", 0);
        }
        else
        {
            score5 = PlayerPrefs.GetInt("score5");
        }
        s.text = "Best score: " + score5;
    }

    // Update is called once per frame
    void Update()
    {
        score5 = PlayerPrefs.GetInt("score5");
        s.text = "Best score: " + score5;
    }
}
