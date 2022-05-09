using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int nextSceneLoad;
    public int score;
    public string scene;
    public PlayerCollect collect;
    public int highest;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        scene = "score";
    }

    public void LoadNextLevel()
    {
        score = collect.score;
        print(score);
        scene += (nextSceneLoad - 2);
        print(scene);
        highest = PlayerPrefs.GetInt(scene, score);
        if (highest < score)
        {
            PlayerPrefs.SetInt(scene, score);
        }
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(2f);
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            Debug.Log("No More");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            SceneManager.LoadScene(7);
        }

        else
        {
            SceneManager.LoadScene(nextSceneLoad);
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
       
    }

}
