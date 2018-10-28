using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {

    public bool isFiring;
    public BulletController bullet;
    public float bulletSpeed;
    public float timeBetweenShots;
    private float shotCounters;
    public Transform firePoint;
    public PlayerController player;
	
	// Update is called once per frame
	void Update () {
		if (isFiring)
        {
            shotCounters -= Time.deltaTime;
            if (shotCounters <= 0)
            {
                shotCounters = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.bulletSpeed = bulletSpeed;
            }
        }
        else
        {
            shotCounters = 0;
        }
	}
}
