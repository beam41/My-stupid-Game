using UnityEngine;

public class EnemyFireController : MonoBehaviour {

    public EnemyBulletController bullet;
    public float bulletSpeed;
    public float timeBetweenShots;
    private float shotCounters;
    public Transform firePoint;
    public EnemyController enemy;

    void Start()
    {
        shotCounters = timeBetweenShots;
    }
    // Update is called once per frame
    void Update()
    {
        shotCounters -= Time.deltaTime;
        if (shotCounters <= 0)
        {
            shotCounters = timeBetweenShots;
            EnemyBulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as EnemyBulletController;
            newBullet.bulletSpeed = bulletSpeed;
        }
    }
}
