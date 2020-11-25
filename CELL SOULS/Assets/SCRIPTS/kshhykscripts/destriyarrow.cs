using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destriyarrow : MonoBehaviour
{
    public GameObject objectTobbeDEactivated;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow level 1"))
        {
            objectTobbeDEactivated.SetActive(false);
        }
    }
}
