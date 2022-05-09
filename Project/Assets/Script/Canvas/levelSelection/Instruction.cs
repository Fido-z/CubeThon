using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instruction : MonoBehaviour
{
    public GameObject insUI;
    public Button btn;

    void Start()
    {
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("Instruction");
        insUI.SetActive(true);
    }

}
