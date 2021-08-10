using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class felloftheworld : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Scene scene = SceneManager.GetActiveScene();
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(scene.name);
        }
    }
}
