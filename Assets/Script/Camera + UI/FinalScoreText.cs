using UnityEngine;
using UnityEngine.UI;

public class FinalScoreText : MonoBehaviour {

    public Text textScore;
    public Score playerScore;

	void Start () {
        textScore.text = string.Format("Score: {0}", playerScore.score);
    }
}
