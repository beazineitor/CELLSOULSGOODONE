using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    //public AudioSource collectSound;
    public playerhealth saludRobot;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            saludRobot.GainHelath(500);
            //saludRobot.TakeDamage(-100);
            Destroy(gameObject);
            //collectSound.Play();
        }

    }
}
