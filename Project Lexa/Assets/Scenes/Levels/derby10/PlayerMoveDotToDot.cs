using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveDotToDot : MonoBehaviour
{
    public Transform[] dots;
    public float _speed;

    private int dotComplite = 0;


    private void FixedUpdate()
    {

        if (dotComplite >= dots.Length)
            return;

        transform.position = Vector3.MoveTowards(transform.position, dots[dotComplite].position, _speed * Time.fixedDeltaTime);
        if (transform.position.x - dots[dotComplite].position.x == 0 && transform.position.y - dots[dotComplite].position.y == 0)
            dotComplite++;
    }

    
}
