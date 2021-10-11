using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidWeapon : MonoBehaviour
{
    public float time;
    private float i;

    private void FixedUpdate()
    {
        if (i >= time)
        {
            Shoot();
            i = 0;
        }
        else
            i += Time.deltaTime;
    }

    public Transform firePoint;
    public GameObject bullet;

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
