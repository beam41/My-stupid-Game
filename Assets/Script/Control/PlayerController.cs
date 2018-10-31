using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D body;
    public float moveSpeed;
    public FireController fire;
    public float blowScale;
    public float blowPower;
    public float screenFlashTime;
    public float flashIntensity;
    public Camera cam;

    private Vector3 mousePosition;
    private Quaternion rotation;
    private Vector3 playerToEnemy;
    private Collider2D[] enemyToblow;
    private float flashingTime;
    private Color originalColor;
    private Color flashColor;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
        originalColor = cam.backgroundColor;
        flashColor = Color.Lerp(cam.backgroundColor, Color.white, flashIntensity);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            fire.isFiring = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            fire.isFiring = false;
        }
        if (flashingTime >= 0)
        {
            cam.backgroundColor = flashColor;
            flashingTime -= Time.deltaTime;
        }
        else
        {
            cam.backgroundColor = originalColor;
        }
    }

    void FixedUpdate () {
        body.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * moveSpeed, 0.8f),
                                    Mathf.Lerp(0, Input.GetAxis("Vertical") * moveSpeed, 0.8f));

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = -100;
        rotation = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        body.angularVelocity = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && flashingTime <= 0)
        {
            Blower();
            flashingTime = screenFlashTime;
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet") && flashingTime <= 0)
        {
            Blower();
            flashingTime = screenFlashTime;
        }
    }

    private void Blower()
    {
        foreach (EnemyBulletController bullet in FindObjectsOfType<EnemyBulletController>())
        {
            Destroy(bullet.gameObject);
        }
        enemyToblow = Physics2D.OverlapCircleAll(transform.position, blowScale);
        foreach (Collider2D enemy in enemyToblow)
        {
            playerToEnemy = enemy.transform.position - transform.position;
            playerToEnemy.Normalize();
            enemy.GetComponent<Rigidbody2D>().AddForce(playerToEnemy * blowPower);
        }
    }
}
