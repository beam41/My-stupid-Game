using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpeed;

    void Start()
    {
        Destroy(gameObject, 4);
    }
    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
	}
}
