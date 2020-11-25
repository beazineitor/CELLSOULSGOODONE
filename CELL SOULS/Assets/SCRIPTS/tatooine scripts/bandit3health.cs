using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandit3health : MonoBehaviour
{
    public int maxHealth = 2400;
    public int currentHealth;
    public BarraDeSalud healthBar;
    public GameObject objectTobbeDEactivated;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "sword")
        {
            TakeDamageEnemy(500);
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
            objectTobbeDEactivated.SetActive(false);
        }

    }
    void TakeDamageEnemy(int enemyDamage)
    {
        currentHealth -= enemyDamage;
        healthBar.SetHealth(currentHealth);
    }

}
