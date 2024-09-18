using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] float cantidad;
    [SerializeField]string moneda;

    void Start()
    {
       float resultadoTotal = Convertir(1.18f, 0.85f);

        if (moneda == "euro")
        {
            Debug.Log(cantidad + " euros equivale a " + resultadoTotal + " dolares");
        }
        else if (moneda == "dolar")
        {
            Debug.Log(cantidad + " dolares equivale a " + resultadoTotal + " euros");
        }
    }

    float Convertir(float euroADolar, float dolarAEuro)
    {
        


        if (moneda == "euro")
        {
            return cantidad * euroADolar;

            
        }
        else if (moneda == "dolar")
        {
            return  cantidad * dolarAEuro;
            
        }
        else 
        {
            Debug.Log("Introduce dolar o euro");
            return 0;
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
