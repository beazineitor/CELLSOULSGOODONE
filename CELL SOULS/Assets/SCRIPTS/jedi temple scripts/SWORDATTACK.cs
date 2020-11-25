using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWORDATTACK : MonoBehaviour
{
    public BarraDeEstamina swordPoints;
    public GameObject objectToBeActivated;
    [SerializeField] private Animator myAnimationController;
    public BarraDeEstamina potencia;
    //Start is called before the first frame update
    void Start()
    {
        myAnimationController = GetComponent<Animator>();
    }

     //Update is called once per frame
    void Update()
    {
      
    {
        if (Input.GetMouseButtonDown(0) && potencia.currentStamina > 0)
        {
            myAnimationController.SetBool("SWORDATTACK", true);
                Debug.Log("Left click key was pressed");
                print ("attack");
                objectToBeActivated.SetActive(true);
                swordPoints.UseStamina(125);
                print(swordPoints.currentStamina);
                print("collider " + objectToBeActivated.active);

            }
            if (Input.GetMouseButtonUp(0))
            {
                myAnimationController.SetBool("SWORDATTACK", false);
                Debug.Log("Left click key was released");
                print("attack");
                objectToBeActivated.SetActive(false);

            }
    


        }


    }
    
}

