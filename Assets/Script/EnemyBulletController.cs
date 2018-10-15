using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {

    public float bulletSpeed;
    public EnemyController enemy;
    private Rigidbody2D body;
    private Rigidbody2D enemyBody;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        enemy = FindObjectOfType<EnemyController>();
        enemyBody = enemy.GetComponent<Rigidbody2D>();
        body.velocity = enemyBody.velocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }
}
