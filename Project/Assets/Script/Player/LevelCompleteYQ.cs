using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteYQ : MonoBehaviour
{
    public int nextSceneLoad;
    public int score;
    public string scene;
    public PlayerCollectYQ collect;

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
        PlayerPrefs.SetInt(scene, score);
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(2f);
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Debug.Log("No More");
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
