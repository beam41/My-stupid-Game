using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject scoreCanvas;
    private bool notrestart = true;
    // Use this for initialization
    private void OnEnable()
    {
        FindObjectOfType<CameraFollow>().enabled = false;
        Time.timeScale = 0;
        scoreCanvas.SetActive(false);
    }

    private void OnDisable()
    {
        if (notrestart)
        {
            FindObjectOfType<CameraFollow>().enabled = true;
            Time.timeScale = 1;
            scoreCanvas.SetActive(true);
        }
    }

    public void BtnRestart()
    {
        notrestart = false;
        foreach (ExplodeGenerator script in FindObjectsOfType<ExplodeGenerator>())
        {
            script.does = false;
        }
        SceneManager.LoadScene(1);
    }

    public void BtnContinue()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            gameObject.SetActive(false);
        }
    }
}
