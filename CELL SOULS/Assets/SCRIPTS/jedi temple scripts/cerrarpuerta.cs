using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrarpuerta : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myAnimationController.SetBool("cierredepuetaderecha", true);

        }


    }
}
