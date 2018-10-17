using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float spawnDelay;
    private float spawnDelayer;
    private Vector3 spawnPoint;
    private float x;
    private float y;
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
            x = Random.Range(-0.1f, 1.1f);
            y = Random.Range(-0.1f, 1.1f);
            if ((0 > x || x > 1) && (0 > y || y > 1))
            {
                spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(x, y, 10.0f));
                EnemyController newEnemy = Instantiate(enemy, spawnPoint, Quaternion.identity) as EnemyController;
                spawnDelayer = spawnDelay;
            }
        }
    }
}
