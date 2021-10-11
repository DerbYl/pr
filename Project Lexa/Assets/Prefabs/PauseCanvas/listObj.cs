using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listObj : MonoBehaviour
{
    public static GameObject btnPause;
    public static GameObject unPausePanel;

    [SerializeField]
    private GameObject btnPauseN;
    [SerializeField]
    private GameObject unPausePanelN;

    public static void switchPause()
    {
        if (btnPause.activeSelf == true)
        {
            btnPause.SetActive(false);
            unPausePanel.SetActive(true);
        } else
        {
            btnPause.SetActive(true);
            unPausePanel.SetActive(false);
        }
    }

    private void Awake()
    {
        btnPause = btnPauseN;
        btnPause.SetActive(true);

        unPausePanel = unPausePanelN;
        unPausePanel.SetActive(false);
    }
}
