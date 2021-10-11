using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speedNpc;
    private float WaitTime;
    public float startWaitTime;


    public Transform[] moveSpots;
    private int randonSpot;

    
    void Start()
    {
        randonSpot = Random.Range(0, moveSpots.Length);
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randonSpot].position, Time.deltaTime);


        if (Vector2.Distance( transform.position, moveSpots[randonSpot].position) < 0.2f) {
            if (WaitTime <= 0)
            {
                randonSpot = Random.Range(0, moveSpots.Length);
                WaitTime = startWaitTime;
            }
            else {
                WaitTime -= Time.deltaTime;
            }
        }
    }
}
