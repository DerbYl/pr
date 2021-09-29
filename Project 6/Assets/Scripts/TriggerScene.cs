using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // Если игрок вызвал тригер сменить уровень на след.
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Загружает следующую сцену.

            // Если номер уровня < количества пройденных. // 2ка используется как id самого первого уровня.
            if ((SceneManager.GetActiveScene().buildIndex - 2) >= PlayerPrefs.GetInt("levelComplite"))
                PlayerPrefs.SetInt("levelComplite", PlayerPrefs.GetInt("levelComplite") + 1); // Прибавить к пройденным + 1
        }
    }
}
