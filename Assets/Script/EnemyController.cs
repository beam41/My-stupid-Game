using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Rigidbody2D enemyBody;
    public float moveSpeed;
    public float rotateSpeed;
    public PlayerController player;

	// Use this for initialization
	void Start () {
        enemyBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, -1);
        Quaternion rotation = Quaternion.LookRotation(transform.position - playerPosition, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed); ;

        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        enemyBody.angularVelocity = 0;
        enemyBody.velocity = transform.up * moveSpeed;
    }
}
