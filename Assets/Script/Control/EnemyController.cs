using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Rigidbody2D enemyBody;
    public int health;
    public float moveSpeed;
    public float rotateSpeed;
    public Transform player;
    public float lifetime;

    private Vector3 playerPosition;
    private Quaternion rotation;
    private Vector3 selfToPlayer;

    // Use this for initialization
    void Start () {
        enemyBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>().transform;
        Destroy(gameObject, lifetime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        selfToPlayer = transform.position - player.position;
        if (selfToPlayer.sqrMagnitude <= 300)
        {
            playerPosition = new Vector3(player.position.x, player.position.y, -100);
            rotation = Quaternion.LookRotation(transform.position - playerPosition, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed);
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
            enemyBody.angularVelocity = 0;
        }
        enemyBody.AddForce(transform.up * moveSpeed);

    }
}
