using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public PlayerCollect collect;
    public Text coinsText;
    public int coins = 0;

    // Update is called once per frame
    void Update()
    {
        coins = collect.score;
        coinsText.text = "Coins: " + coins;
    }
}
