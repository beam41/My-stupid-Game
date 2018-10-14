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

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isFiring)
        {
            shotCounters -= Time.deltaTime;
            if (shotCounters <= 0)
            {
                shotCounters = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.bulletSpeed = bulletSpeed + Mathf.Sqrt(Mathf.Pow(player.body.velocity.x < 0 ? 0 : player.body.velocity.x, 2) + 
                                                                 Mathf.Pow(player.body.velocity.y < 0 ? 0 : player.body.velocity.y, 2));
            }
        }
        else
        {
            shotCounters = 0;
        }
	}
}
