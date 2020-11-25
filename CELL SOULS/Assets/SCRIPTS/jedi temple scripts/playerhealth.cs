using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public int maxHealth = 1000;
    public int currentHealth;
    public BarraDeSalud healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);

        }
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }
    }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
        public void GainHelath(int health)
        {
            currentHealth += health;
            healthBar.SetHealth(currentHealth);
        }
    }
