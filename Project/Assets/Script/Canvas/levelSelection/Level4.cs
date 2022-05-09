using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level4 : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void OnClick()
    {
        Debug.Log("Click4");
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(5);
    }
}