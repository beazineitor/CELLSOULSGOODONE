using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IApasiva : MonoBehaviour
{
    [Header("Ajustes")]
    public int tiempo;
    public float speed;
    bool tiempoDeGiro;
        float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        tiempo += 1;
        transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
        transform.Rotate(new Vector3(0, y, 0));
        if(tiempo >= Random.Range(10, 30))
        {
            girar();
            tiempo = 0;
            tiempoDeGiro = true;
        }
        if (tiempoDeGiro == true)
        {
            if (tiempo >= Random.Range(50, 100))
            {
                y = 0;
                tiempoDeGiro = false;
            }
        }
    }
public void girar()
    {
        y = Random.Range(-3,3);
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "scenary")
        {
            girar();
        }
    }
}
