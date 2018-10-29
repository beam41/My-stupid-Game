using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpeed;
    public int damageToGive;
    public PlayerController player;
    public float bulletForce;
    private Rigidbody2D body;
    private Rigidbody2D playerBody;

    void Start()
    {
        Destroy(gameObject, 10);
        body = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>();
        playerBody = player.GetComponent<Rigidbody2D>();
        body.velocity = playerBody.velocity;
    }

    // Update is called once per frame
    void FixedUpdate () {
        transform.Translate(Vector3.up * bulletSpeed * Time.fixedDeltaTime);

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.GetComponent<EnemyHealthController>().Hurt(damageToGive);
            collision.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletForce * collision.GetComponent<EnemyController>().moveSpeed/2);
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject, 1);
    }
}
