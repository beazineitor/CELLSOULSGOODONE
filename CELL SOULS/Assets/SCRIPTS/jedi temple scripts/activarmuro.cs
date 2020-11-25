using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarmuro : MonoBehaviour
{
    public GameObject objectToACtivate;
    public void OnTriggerEnter(Collider other)
    {
        objectToACtivate.SetActive(true);
        print("Triggered");
    }
}
