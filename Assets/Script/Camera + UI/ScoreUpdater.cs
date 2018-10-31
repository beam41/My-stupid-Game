using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour {

    public Text textScore;
    public Score playerScore;
	
	// Update is called once per frame
	void Update () {
        textScore.text = string.Format("Score:\n{0}", playerScore.score);
	}
}
