using UnityEngine;
using UnityEngine.UI;

public class FinalScoreText : MonoBehaviour {

    public Text textScore;

	void Start () {
        textScore.text = string.Format("Score: {0}", FindObjectOfType<Score>().score);
    }
}
