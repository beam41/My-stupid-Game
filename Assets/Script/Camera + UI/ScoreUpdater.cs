using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour {

    public Text textScore;
    public Score playerScore;
	
	// Update is called once per frame
	void Update () {
        textScore.text = playerScore.score.ToString();
	}
}
