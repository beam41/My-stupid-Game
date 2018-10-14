using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D body;
    public float moveSpeed;
    public float turnSpeed;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        body.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime, 0.8f),
                                    Mathf.Lerp(0, Input.GetAxis("Vertical") * moveSpeed * Time.fixedDeltaTime, 0.8f));

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rotation = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
        
    }

}
