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
            Time.timeScale = 0;
        }
    }

    public void Hurt(int damage)
    {
        health -= damage;
    }
}
