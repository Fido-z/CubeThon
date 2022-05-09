using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToLevelSelect : MonoBehaviour
{
    public Button btn;

    void Start()
    {
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("BackToLevelSelect");
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
