using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticEnemy : MonoBehaviour
{
    PlayerHealth player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
        gameObject.tag = "Enemy";
    }

    void OnCollisionEnter(Collision other) 
    {
        Scene scene = SceneManager.GetActiveScene();
        if (other.gameObject.tag == "Enemy" && player.Health <= 0f)
        {
            SceneManager.LoadScene(scene.name);
        }
    }
}
