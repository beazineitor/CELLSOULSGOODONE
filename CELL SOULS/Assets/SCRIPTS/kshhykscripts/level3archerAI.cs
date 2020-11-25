using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3archerAI : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;

    public Transform player;

    //Attacking



    //States


    private void Awake()
    {
        player = GameObject.Find("ThirdPersonController_LITE Variant").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= 20) AttackPlayer();
    }

    private void AttackPlayer()
    {


        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);

        transform.LookAt(player);



    }

}
