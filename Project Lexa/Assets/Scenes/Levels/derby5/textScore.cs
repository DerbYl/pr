using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScore : MonoBehaviour
{
    Text text;

    public static int score = 0;

    private void Awake()
    {
        text = gameObject.GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        text.text = "Score: " + score + "\nBest Score: " + PlayerPrefs.GetInt("bestScoreLevel6");


        if (score >= 10 && PlayerPrefs.GetInt("levelComplite") < 5)
            PlayerPrefs.SetInt("levelComplite", PlayerPrefs.GetInt("levelComplite") + 1);

    }
}
