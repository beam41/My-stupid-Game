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
    private bool forceSpawn;

    // Use this for initialization
    void Start () {
        spawnDelayer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        spawnDelayer -= Time.deltaTime;
        if (spawnDelayer <= 0)
        {
            if (Spawn())
            {
                spawnDelayer = spawnDelay;
            }
        }
        if (forceSpawn)
        {
            forceSpawn = !Spawn();
        }
    }

    public void ForcedSpawner()
    {
        forceSpawn = true;
    }

    private bool Spawn()
    {
        x = Random.Range(-0.1f, 1.1f);
        y = Random.Range(-0.1f, 1.1f);
        if ((0 > x || x > 1) && (0 > y || y > 1))
        {
            spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(x, y, 10.0f));
            Instantiate(enemy, spawnPoint, Quaternion.identity);
            return true;
        }
        return false;
    }
}
