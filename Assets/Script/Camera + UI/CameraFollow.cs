using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    private float m_OffsetZ;
    private Vector3 mousePosition;
    private Vector3 deltaPositon;
    private Vector3 towardPosition;

    // Use this for initialization
    private void Start()
    {
        m_OffsetZ = (transform.position - target.position).z;
        transform.parent = null;
    }

    // Update is called once per frame
    void Update () {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        deltaPositon = mousePosition - target.position;

        towardPosition = new Vector3(deltaPositon.x / 10, deltaPositon.y / 10);
        transform.position = target.position + Vector3.forward * m_OffsetZ + towardPosition;
    }
}
