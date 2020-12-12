using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwablesword : MonoBehaviour
{
    public Rigidbody sword;
    public float throwForce = 50;
    public Transform target, curvePoint;
    private bool isReturning = false;
    private Vector3 oldPos;
    private float time = 0.0f;
    public GameObject objectToBeActivated;
    public GameObject activateCollider;
    public BarraDeEstamina saberPoints;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && saberPoints.currentStamina > 0)
        {
            ThrowSword();
            objectToBeActivated.SetActive(true);
            activateCollider.SetActive(true);
            saberPoints.UseStamina(125);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
           returnSword();
        }
        if (isReturning)
        {
            if (time < 1.0f)
            {
                sword.position = getBQCPoint(time, oldPos, curvePoint.position, target.position);
                time += Time.deltaTime;
                objectToBeActivated.SetActive(false);
                activateCollider.SetActive(false);
            }
            else
            {
                resetSword();
                sword.transform.parent = target;
                sword.position = target.position;
                sword.rotation = target.rotation;
            }
        }
    }
    void ThrowSword()
    {
        sword.transform.parent = null;
        sword.isKinematic = false;
        sword.AddForce(Camera.main.transform.TransformDirection(Vector3.forward)*throwForce, ForceMode.Impulse);
        sword.AddRelativeTorque(sword.transform.InverseTransformDirection(Vector3.right) * 100, ForceMode.Impulse);
    }
    void returnSword()
    {
        time = 0;
        oldPos = sword.position;
        isReturning = true;
        sword.position += target.position - sword.position;
        sword.velocity = Vector3.zero;
        sword.isKinematic = true;
    }
    void resetSword()
    {
        isReturning = false;
    }
    Vector3 getBQCPoint(float t,Vector3 p0, Vector3 p1,Vector3 p2)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector3 p = (uu * p0) + (2 * u * t * p1) + (tt * p2);
        return p;
    }

}
