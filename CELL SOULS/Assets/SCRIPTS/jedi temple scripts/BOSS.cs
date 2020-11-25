using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    public int maxHealth = 40000;
    public int currentHealth;
    public BarraDeSalud healthBar;
    public GameObject objectTobbeDEactivated;
    public bool attacked = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "sword" && attacked == false)
        {
            TakeDamageEnemy(500);
            attacked = true;
            print("enemyattacked");
            print("currentHealth " + currentHealth);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "sword" && attacked == true)
        {
            attacked = false;
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (currentHealth == 0)
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
