using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirpuerta : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myAnimationController.SetBool("puertaderecha", true);

        }


    }
}
