using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIRARTABLAS : MonoBehaviour
{
    public GameObject objectToDeaACtivate2;
    public GameObject objectToDeactivate;
    public GameObject edeactivateEnemy;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sword")
        {
            objectToDeaACtivate2.SetActive(false);
            objectToDeactivate.SetActive(false);
            edeactivateEnemy.SetActive(false);
            print("Triggered");
        }
    }
}
