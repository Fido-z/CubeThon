using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelSelect : MonoBehaviour
{
    public Menu menu;

    // Start is called before the first frame update
    public void classic()
    {
        menu.StartGame();
    }

    public void advanced()
    {
        SceneManager.LoadScene(7);
    }
}
