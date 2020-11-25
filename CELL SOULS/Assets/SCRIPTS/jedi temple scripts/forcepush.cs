using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcepush : MonoBehaviour
{
    public float pushAmount;
    public float chargeRate;
    private float amtStart;
    private float radiusStart;
    public float pushRadius;
    public bool showGizmos = true;

    private void Start()
    {
        amtStart = pushAmount;
        radiusStart = pushRadius;
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            DoPush();
        }
        if (Input.GetKey(KeyCode.E))
        {
            pushAmount += chargeRate;
            pushRadius += chargeRate;
           // if(pushRadius > 25)
            {
                //pushRadius = 25;
            }
        }
    }
    public void DoPush()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, pushRadius);
        foreach(Collider pushedObjec in colliders)
        {
            if (pushedObjec.CompareTag("cosa"))
            {
                Rigidbody pushedBody = pushedObjec.GetComponent<Rigidbody>();
                pushedBody.AddExplosionForce(pushAmount, transform.position, pushRadius);
                    
            }
        }
        pushAmount = amtStart;
        pushRadius = radiusStart;


    }
    private void OnDrawGizmos()
    {
        if (showGizmos){
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, pushRadius);
        }
   
    }
}
