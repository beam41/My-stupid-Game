using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Rigidbody2D enemyBody;
    public int health;
    public float moveSpeed;
    public float rotateSpeed;
    public PlayerController player;

    private Vector3 playerPosition;
    private Quaternion rotation;

    // Use this for initialization
    void Start () {
        enemyBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        rotation = Quaternion.LookRotation(transform.position - playerPosition, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed); ;

        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        enemyBody.angularVelocity = 0;
        enemyBody.velocity = transform.up * moveSpeed;
    }
}
