using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banditIA1 : MonoBehaviour
{
    public GameObject target;
    public UnityEngine.AI.NavMeshAgent agent;
    public float distance;
    public playerhealth botHealth;
    public float timeRemaining = 3;
    public BANDITLEVEL1HEALTH bandit1Health;
    public GameObject objectTobbeDEactivated;



    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) < distance)
        {
            agent.SetDestination(target.transform.position);
            agent.speed = 5;
        }
        else
        {
            agent.speed = 0;
        }
        if (Vector3.Distance(target.transform.position, transform.position) <= 2)
        {

            if (timeRemaining > 0)
                timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                botHealth.TakeDamage(50);
                print(botHealth.currentHealth);
                timeRemaining = 2;
            }
            if (bandit1Health.currentHealth <= 0)
            {
                Destroy(objectTobbeDEactivated);
            }
        }



    }
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        botHealth = target.GetComponent<playerhealth>();
    }
}
