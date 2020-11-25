using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireArrow : MonoBehaviour
{
    public Transform player;
    public bool alreadyAttacked, playerInAttackRange;
    public GameObject projectile;
    public float attackRange, arrowSpeed, cooldown, cooldownReset;

    private void Awake()
    {
        cooldownReset = cooldown;
    }

    private void Update()
    {

        checkDistance();

        if (!alreadyAttacked && playerInAttackRange)
            AttackPlayer();

        if (alreadyAttacked)
        {
            cooldown = cooldown - Time.deltaTime;
            if(cooldown < 0)
            {
                cooldown = cooldownReset;
                alreadyAttacked = false;
            }
        }
    }


    private void checkDistance()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= attackRange)
            playerInAttackRange = true;

        else playerInAttackRange = false;
    }

    void AttackPlayer()
    {
        //transform.LookAt(player);
        alreadyAttacked = true;

        Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * arrowSpeed, ForceMode.Impulse);
    }
}
