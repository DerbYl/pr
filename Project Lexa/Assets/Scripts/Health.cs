using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 0;

    private GameObject gameObjectCanvasLose;
    private GameObject gameObjectCanvasMove;

    private void Awake()
    {
        
    }

    /*
    Применение: На все обьекты, сквозь которые не должна просто так проходить "кислота". (Стены, столы, стулья, NPC и т.п)

    Функция срабатывает, когда "кислота" трогает какой-либо обьект.
    Выставлять -1 и меньше(по желанию), если обьект не должен разрушаться.
    
    tag: NPC есть возможность не высталять хп, ибо игра закончиться без провеки, сколько у него жизней.
    */
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Acid")) // Часть кода будет выполняться, если "кислота" дотронулась до обьекта со скриптом.
        { 
            
            Destroy(other.gameObject); // Удаление "кислоты".
            
            if (gameObject.tag.Equals("NPC")) // Если пуля достонулась до игрока.
            {

                canvasList.canvasControll.SetActive(false);
                canvasList.canvasLose.SetActive(true);

            } 
            else if (health == 0) // Если у обьекта 0 HP, разрушаем его.
            { 
                Destroy(gameObject);
            } 
            else if (health > 0) // Если больше 0, уменьшаем.
            { 
                health -= 1;
            }
        }
    }
}
