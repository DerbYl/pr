using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody2D;

    public Transform transform1;
    public Transform transform2;
    void Start()
    {
        rigidbody2D.AddForce(new Vector2((transform2.position.x - transform1.position.x) * speed,
                                        (transform2.position.y - transform1.position.y) * speed));
    }

}
