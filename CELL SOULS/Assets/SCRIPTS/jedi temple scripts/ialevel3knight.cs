using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ialevel3knight : MonoBehaviour
{
    public GameObject target;
    public UnityEngine.AI.NavMeshAgent agent;
    public float distance;
    public playerhealth botHealth;
    public float timeRemaining = 4;
    public leve3knight caballeronvl3;
    public GameObject objectTobbeDEactivated;



    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) < distance)
        {
            agent.SetDestination(target.transform.position);
            agent.speed = 2;
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
                botHealth.TakeDamage(850);
                timeRemaining = 8;
            }
            if (caballeronvl3.currentHealth <= 0)
            {
                Destroy(objectTobbeDEactivated);
            }
        }



    }
}
