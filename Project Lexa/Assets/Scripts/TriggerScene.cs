using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canvasList.canvasControll.SetActive(false);
            canvasList.canvasLose.SetActive(true);

            if (canvasList.nextLevel != null)
                canvasList.nextLevel.interactable = true;
            GameObject.Find("GameOverText").GetComponent<Text>().text = "You win!";

            if ((SceneManager.GetActiveScene().buildIndex - 2) >= PlayerPrefs.GetInt("levelComplite"))
                PlayerPrefs.SetInt("levelComplite", PlayerPrefs.GetInt("levelComplite") + 1);
        }
    }
}
