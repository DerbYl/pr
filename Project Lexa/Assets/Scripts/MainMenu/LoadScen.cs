using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScen : MonoBehaviour
{

    public void loadLevelMap(){
        SceneManager.LoadScene("LevelMap");
    }
    
    public void startGame(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("levelComplite") + 2);
    }
}
