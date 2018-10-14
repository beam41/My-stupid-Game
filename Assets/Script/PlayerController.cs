using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D body;
    public float moveSpeed;
    public FireController fire;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
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
    }
    void FixedUpdate () {

        body.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * moveSpeed, 0.8f),
                                    Mathf.Lerp(0, Input.GetAxis("Vertical") * moveSpeed, 0.8f));

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rotation = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        body.angularVelocity = 0;

    }

}
