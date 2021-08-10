using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Bonk";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.tag = "Bonked";
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
