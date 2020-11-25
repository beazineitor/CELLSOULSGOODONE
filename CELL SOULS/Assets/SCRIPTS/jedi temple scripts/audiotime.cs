using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiotime : MonoBehaviour
{
  
    public AudioSource advetisment;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            advetisment.Play();
        }

    }
}
