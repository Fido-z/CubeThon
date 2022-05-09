using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordScore1 : MonoBehaviour
{
    public PlayerCollect collect;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score = collect.score;
        PlayerPrefs.SetInt("score1", score);
    }
}
