using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciondetabla : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sword")
        {
            myAnimationController.SetBool("tabla", true);

        }


    }
}
