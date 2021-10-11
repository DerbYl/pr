using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBTN : MonoBehaviour
{
    public int idLevel;

    private void Awake()
    {
        int i = PlayerPrefs.GetInt("levelComplite");
        Button btn = GetComponent<Button>();
        if (idLevel <= i){
            btn.interactable = true;
        } else {
            btn.interactable = false;
        }
    }
}
