using UnityEngine;

public class EnemyHealthController : MonoBehaviour {

    public int health;

    // Update is called once per frame
    void Update () {
		
        if (health <= 0)
        {
            FindObjectOfType<EnemySpawner>().Spawn();
            FindObjectOfType<Score>().AddScore(10);
            Destroy(gameObject);
        }
	}

    public void Hurt(int damage)
    {
        health -= damage;
    }
}
