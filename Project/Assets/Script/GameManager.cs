using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject pauseUI;
    /*public int nextSceeneLoad;

    void Start()
    {
        nextSceeneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }*/

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("level win");
        completeLevelUI.SetActive(true);
        //time.scoreText.SetActive(false);
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
    }

    public void continueGame()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void q()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
