using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROllinganimation : MonoBehaviour
{
    public BarraDeEstamina consumicionDeEstamina;
    [SerializeField] private Animator myAnimationController;
    // Start is called before the first frame update
    void Start()
    {
       // myAnimationController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetKeyDown(KeyCode.O))
            {

                myAnimationController.SetBool("jumpover", true);
                Debug.Log("Left click key was pressed");
                print("Roll");
                consumicionDeEstamina.UseStamina(125);
                print(consumicionDeEstamina.currentStamina);

            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                myAnimationController.SetBool("jumpover", false);
                Debug.Log("Left click key was released");
                print("Roll");
             
            }


        }
    }
}
