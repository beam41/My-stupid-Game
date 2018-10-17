﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {

    public float bulletSpeed;
    public EnemyController enemy;
    public int damageToGive;
    private Rigidbody2D body;
    private Rigidbody2D enemyBody;

    void Start()
    {
        Destroy(gameObject, 4);
        body = GetComponent<Rigidbody2D>();
        enemy = FindObjectOfType<EnemyController>();
        enemyBody = enemy.GetComponent<Rigidbody2D>();
        body.velocity = enemyBody.velocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealthController>().Hurt(damageToGive);
            Destroy(gameObject);
        }
    }
}
