using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class RotateArroundDot : MonoBehaviour
{

    public Transform center;
    public float radius = 2f, anglarSpeed = 2f;
    float posX, posY;
    public float angle = 0;
 
    public LongPress lpLeft;
    public LongPress lpRight;

    private void Update()
    {
        posX = center.position.x + Mathf.Cos(angle) * radius;
        posY = center.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(posX, posY);
        if (lpLeft.isDown)
        {
            angle = angle + Time.deltaTime * anglarSpeed;            
        }
        else if(lpRight.isDown)
        {
            angle = angle - Time.deltaTime * anglarSpeed;
        }
        if (angle < 0f)
        {
            angle = 6.35f;

        }
    }
}
