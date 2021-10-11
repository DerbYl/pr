using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrainBTN : MonoBehaviour
{

    public void openLevelMap()
    {
        SceneManager.LoadSceneAsync("LevelMap");
    }

    public void restartLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    public void openMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void nextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
