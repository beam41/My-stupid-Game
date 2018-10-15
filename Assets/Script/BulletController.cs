﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpeed;
    public PlayerController player;
    private Rigidbody2D body;
    private Rigidbody2D playerBody;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();
        playerBody = player.GetComponent<Rigidbody2D>();
        body.velocity = playerBody.velocity;
    }

    // Update is called once per frame
    void FixedUpdate () {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }
}