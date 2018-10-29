﻿using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float spawnDelay;
    private float spawnDelayer;
    private float a;
    private float b;
    private Vector3 spawnPoint;
    private float[] spawner = { -0.1f, 1.1f };
    public EnemyController enemy;

    // Use this for initialization
    void Start () {
        spawnDelayer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        spawnDelayer -= Time.deltaTime;
        if (spawnDelayer <= 0)
        {
            Spawn();
            spawnDelayer = spawnDelay;
        }
    }

    public void Spawn()
    {
        spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(spawner[Random.Range(0, 2)], spawner[Random.Range(0, 2)], 10.0f));
        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }
}
