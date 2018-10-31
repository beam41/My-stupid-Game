using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUpdater : MonoBehaviour {

    public Text textHealth;
    public PlayerHealthController playerHealth;

    // Update is called once per frame
    void Update()
    {
        textHealth.text = string.Format("Health:\n{0}", playerHealth.health);
    }
}
