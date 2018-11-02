using UnityEngine;

public class PlayerHealthController : MonoBehaviour {

    public int health;
    public GameObject endMenu;

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            endMenu.SetActive(true);
            gameObject.GetComponent<ExplodeGenerator>().ForceBombGenerator();
            Time.timeScale = 0;
            FindObjectOfType<CameraFollow>().enabled = false;
            enabled = false;
        }
    }

    public void Hurt(int damage)
    {
        health -= damage;
    }
}
