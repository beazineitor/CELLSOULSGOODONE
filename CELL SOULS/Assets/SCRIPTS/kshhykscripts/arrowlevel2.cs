using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowlevel2 : MonoBehaviour
{
    public playerhealth saludBot;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            saludBot.TakeDamage(250);
        }
    }
}
