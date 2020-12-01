
using UnityEngine;
using UnityEngine.AI;

public class EnemyAiTutorial : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    //Attacking



    //States


    private void Awake()
    {
        player = GameObject.Find("ThirdPersonController_LITE Variant (1) Variant").transform;
        agent = GetComponent<NavMeshAgent>();
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
