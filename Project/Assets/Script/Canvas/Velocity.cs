using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Velocity : MonoBehaviour
{
    [SerializeField] Slider velocitySlider;
    public Ex_PlayerMovement p;

    void Start()
    {
        if (!PlayerPrefs.HasKey("Velocity"))
        {
            PlayerPrefs.SetFloat("Velocity", 6.5f);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVelocity()
    {
        p.addF = velocitySlider.value;
        Save();
    }

    public void Load()
    {
        velocitySlider.value = PlayerPrefs.GetFloat("Velocity");
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("Velocity", velocitySlider.value);
    }
}
