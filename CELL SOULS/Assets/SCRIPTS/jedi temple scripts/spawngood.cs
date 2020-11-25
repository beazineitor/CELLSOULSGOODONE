using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawngood : MonoBehaviour
{
    [SerializeField] private Transform spawner;
    [SerializeField] private Transform newrespawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawner.transform.position = newrespawnPoint.transform.position;
            Physics.SyncTransforms();
      
        }
    }
}
