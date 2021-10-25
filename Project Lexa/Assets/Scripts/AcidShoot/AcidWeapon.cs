using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidWeapon : MonoBehaviour
{
    [SerializeField] private float time;
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

    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bullet;

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
