using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoors : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myAnimationController.SetBool("puertaizquierda", true);

        }


    }
}
