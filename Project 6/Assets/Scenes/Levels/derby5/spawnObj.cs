using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObj : MonoBehaviour
{
    private int level = 0;
    private int exp = 0;

    public Transform pos1, pos2;
    public GameObject[] listGameObj;

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        float time = 3f - (level * 0.1f);
        if (time < 0.5f)
            time = 0.5f;

        if (exp > 2 * level)
        {
            exp = 0;
            level += 1;
        }

        yield return new WaitForSeconds(time);


        Instantiate(listGameObj[Random.Range(0, listGameObj.Length)], new Vector3(Random.Range(pos1.position.x, pos2.position.x), Random.Range(pos1.position.y, pos2.position.y), 0f), Quaternion.identity);
        textScore.score += 1;

        StartCoroutine(spawn());

    }

}
