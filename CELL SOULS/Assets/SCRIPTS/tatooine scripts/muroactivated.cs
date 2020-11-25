using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muroactivated : MonoBehaviour
{
    public GameObject objectToACtivate;
    public void OnTriggerEnter(Collider other)
    {
        objectToACtivate.SetActive(true);
        print("Triggered");
    }
}
