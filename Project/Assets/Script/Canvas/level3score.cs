using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level3score : MonoBehaviour
{
    public int score3;
    public Text s;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("score3"))
        {
            PlayerPrefs.SetInt("score3", 0);
        }
        else
        {
            score3 = PlayerPrefs.GetInt("score3");
        }
        s.text = "Best score: " + score3;
    }

    // Update is called once per frame
    void Update()
    {
        score3 = PlayerPrefs.GetInt("score3");
        s.text = "Best score: " + score3;
    }
}

