using UnityEngine;
using UnityEngine.UI;

public class TransperentToggler : MonoBehaviour {

    private Image panel;
    private Color c;

	// Use this for initialization
	void Start () {
        panel = gameObject.GetComponent<Image>();
        c = panel.color;
        c.a = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (c.a < 0.79)
        {
            c.a = Mathf.Lerp(c.a, 0.8f, 0.1f);
            panel.color = c;
        }
        else
        {
            enabled = false;
        }
	}
}
