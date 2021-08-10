using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Landingboi : MonoBehaviour
{
    public Playermove playermove;
    [SerializeField] [Range(1,100)] int bonk = 1;
    void Start() 
    {
        playermove = GameObject.Find("Player").GetComponent<Playermove>(); 
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player" && playermove.Bonks == bonk)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
