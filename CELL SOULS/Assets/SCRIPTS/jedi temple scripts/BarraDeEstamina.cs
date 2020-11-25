using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarraDeEstamina : MonoBehaviour
{
    public Slider staminaBar;
    private int maxStamina=750;
    public int currentStamina;
    public static BarraDeEstamina instance;
    private WaitForSeconds regenTick = new WaitForSeconds (0.1f);
    private Coroutine regen;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentStamina = maxStamina;
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;
    }
    public void UseStamina(int ammount)
    {
        if (currentStamina - ammount >= 0)
        {
            currentStamina -= ammount;
            staminaBar.value = currentStamina;
            if (regen != null)
                StopCoroutine(regen);

            regen = StartCoroutine(regenStamina());

        }
        else
        {
            Debug.Log("NotEnoughStamina");
        }
    }
    private IEnumerator regenStamina()
    {
        yield return new WaitForSeconds(2);
        
        while(currentStamina < maxStamina)
        {
            currentStamina += maxStamina / 25;
            staminaBar.value = currentStamina;
            yield return regenTick;
        }
        regen = null;
      
    }

}
