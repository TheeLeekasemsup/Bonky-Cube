using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    PlayerHealth player;
    void OnCollisionEnter(Collision other) 
    {
        player = FindObjectOfType<PlayerHealth>();
        Scene scene = SceneManager.GetActiveScene();
        if(other.gameObject.tag == "Enemy" && player.Health <= 0f)
        {
            SceneManager.LoadScene(scene.name);
        }
    }
}
