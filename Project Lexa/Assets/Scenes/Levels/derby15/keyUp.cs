using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyUp : MonoBehaviour
{

    public GameObject destroyGameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "key")
        {
            Destroy(collision.gameObject); // Удаление ключа
            Destroy(destroyGameObject); // Удаление определенного gameObj
        }
            
    }
}
