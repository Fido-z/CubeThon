using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //public AudioSource audio = null;
    public GameObject panel;
    public GameObject welcome;

    public void StartGame()
    {
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void toLevelSelect()
    {
        panel.SetActive(true);
        welcome.SetActive(false);
    }

    public void advanced()
    {
        StartCoroutine(DelaySceneLoad2());
    }

    IEnumerator DelaySceneLoad2()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(8);
    }
}
