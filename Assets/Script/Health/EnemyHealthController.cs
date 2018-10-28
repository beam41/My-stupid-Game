using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour {

    public int health;

    // Update is called once per frame
    void Update () {
		
        if (health <= 0)
        {
            FindObjectOfType<EnemySpawner>().ForcedSpawner();
            FindObjectOfType<PlayerController>().GetComponent<Score>().AddScore(10);
            Destroy(gameObject);
        }
	}

    public void Hurt(int damage)
    {
        health -= damage;
    }
}
