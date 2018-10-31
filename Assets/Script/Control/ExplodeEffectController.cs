using UnityEngine;

public class ExplodeEffectController : MonoBehaviour {

    public float explodedSpeed;
    public float explodedTime;

    private Vector3 increser;

    void Start () {
        increser = new Vector3(explodedSpeed, explodedSpeed, 0);
    }

    // Update is called once per frame
    void FixedUpdate () {
		if (explodedTime > 0)
        {
            transform.localScale += increser;
            explodedTime -= Time.fixedDeltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
	}

    public void ForceBombed(float size)
    {
        transform.localScale = new Vector3(size, size, 0);
    }
}
