using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    private float m_OffsetZ;

    // Use this for initialization
    private void Start()
    {
        m_OffsetZ = (transform.position - target.position).z;
        transform.parent = null;
    }

    // Update is called once per frame
    void Update () {
        transform.position = target.position + Vector3.forward * m_OffsetZ;
    }
}
