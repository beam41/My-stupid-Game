using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenu : MonoBehaviour {

    void OnEnable()
    {
        GameObject.Find("Score Canvas").SetActive(false);
    }

    public void BtnRestart()
    {
        foreach (ExplodeGenerator script in FindObjectsOfType<ExplodeGenerator>())
        {
            script.does = false;
        }
        SceneManager.LoadScene(1);
    }
}
