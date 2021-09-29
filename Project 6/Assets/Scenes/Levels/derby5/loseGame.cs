using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseGame : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obj")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            if (textScore.score > PlayerPrefs.GetInt("bestScoreLevel6"))
            {
                PlayerPrefs.SetInt("bestScoreLevel6", textScore.score);
            }
            textScore.score = 0;
        }
            
    }
}
