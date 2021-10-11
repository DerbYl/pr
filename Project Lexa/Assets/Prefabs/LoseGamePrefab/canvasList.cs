using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasList : MonoBehaviour
{
    public static GameObject canvasLose;
    public static GameObject canvasControll;
    public static Button nextLevel;


    [SerializeField]
    private GameObject canvasLoseN;
    [SerializeField]
    private GameObject canvasControllN;
    [SerializeField]
    private Button nextLevelN;



    private void Awake()
    {
        canvasLose = canvasLoseN;
        canvasControll = canvasControllN;

        nextLevel = nextLevelN;
        if (nextLevel != null)
            nextLevel.interactable = false;

    }
}
