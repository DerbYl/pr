using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    private void Start() {
        Animation anim = GetComponent<Animation>();
        anim.Play();
        
    }
}
