using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    public float MaxHealth = 100f;
    PlayerHealth Player;
    private void Start() 
    {
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerHealth>(); 
    }
    private void Update() 
    {
        CurrentHealth = Player.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
