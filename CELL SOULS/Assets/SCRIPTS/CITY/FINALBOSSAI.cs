using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FINALBOSSAI : MonoBehaviour
{
    public GameObject target;
    public UnityEngine.AI.NavMeshAgent agent;
    public float distance;
    public playerhealth botHealth;
    public float timeRemaining = 2;
    public FINALBOSSHEALTH FINALBOS;
    public GameObject objectTobbeDEactivated;



    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) < distance)
        {
            agent.SetDestination(target.transform.position);
            agent.speed = 3;
        }
        else
        {
            agent.speed = 0;
        }
        if (Vector3.Distance(target.transform.position, transform.position) <= 5)
        {

            if (timeRemaining > 0)
                timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                botHealth.TakeDamage(700);
                timeRemaining = 2;
            }
            if (FINALBOS.currentHealth <= 0)
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
