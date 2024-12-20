using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyRange : MonoBehaviour
{
    public Transform firePoint;
    public GameObject enemyBullet;

    private float shootInterval = 5f;

    void Start()
    {
        InvokeRepeating("ShootEnemy", 0f, shootInterval);
    }

    void ShootEnemy ()
    {
        Instantiate(enemyBullet, firePoint.position, Quaternion.Euler(0, firePoint.rotation.eulerAngles.y + 180, 0));
    }
}
