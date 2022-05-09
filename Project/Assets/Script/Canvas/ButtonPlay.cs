using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlay : MonoBehaviour
{
    public UnityEngine.UI.Button playBtn;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        playBtn.onClick.AddListener(delegate ()
        {
            audio.Play();
        });
    }
}
