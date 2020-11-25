using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staminabartest : MonoBehaviour
{

 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) & (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            BarraDeEstamina.instance.UseStamina(1);
            Debug.Log("Left Shift key is being pressed");
        }
    }
}
