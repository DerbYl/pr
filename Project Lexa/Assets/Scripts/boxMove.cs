using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMove : MonoBehaviour
{
    //public GameObject sound;
    public AudioSource sound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))

            Instantiate(sound, transform.position, Quaternion.identity);
            //sound.Play();
    }
   /* private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            DestroyImmediate(sound, true);
    }*/
}