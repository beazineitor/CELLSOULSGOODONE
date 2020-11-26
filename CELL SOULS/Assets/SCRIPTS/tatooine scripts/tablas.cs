using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablas : MonoBehaviour
{
    public GameObject objectToACtivate;
    public GameObject objectToDeactivate;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sword")
        {
            objectToACtivate.SetActive(true);
            objectToDeactivate.SetActive(false);
            print("Triggered");
        }
    }
}
