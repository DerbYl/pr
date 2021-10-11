using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // Если игрок вызвал тригер сменить уровень на след.
        {
            canvasList.canvasControll.SetActive(false);
            canvasList.canvasLose.SetActive(true);

            if (canvasList.nextLevel != null)
                canvasList.nextLevel.interactable = true;
            GameObject.Find("GameOverText").GetComponent<Text>().text = "You win!";

            // Если номер уровня < количества пройденных. // 2ка используется как id самого первого уровня.
            if ((SceneManager.GetActiveScene().buildIndex - 2) >= PlayerPrefs.GetInt("levelComplite"))
                PlayerPrefs.SetInt("levelComplite", PlayerPrefs.GetInt("levelComplite") + 1); // Прибавить к пройденным + 1
        }
    }
}
