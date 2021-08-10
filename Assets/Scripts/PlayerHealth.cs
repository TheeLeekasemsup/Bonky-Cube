using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] [Range(0f,100f)] float Damage = 50f;
    //player health
    public float Health = 100f;
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            Health -= Damage;
        }
    }
}
