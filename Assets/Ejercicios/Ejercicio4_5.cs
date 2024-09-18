using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] float radioCriculo;
   
    //float areaCirculo;


    [SerializeField] string moneda;

    // Start is called before the first frame update
    void Start()
    {
        float areaCirculo = CirculoArea(radioCriculo, 3.1416f);
        Debug.Log("El area del circulo es " + areaCirculo);

        float dinero = areaCirculo;

        float resultadoTotal = Convertir(1.18f, 0.85f, areaCirculo);

        if (moneda == "euro")
        {
            Debug.Log(areaCirculo + " euros equivale a " + resultadoTotal + " dolares");
        }
        else if (moneda == "dolar")
        {
            Debug.Log(areaCirculo + " dolares equivale a " + resultadoTotal + " euros");
        }

        
    }

    float CirculoArea(float circuloRadio, float pi)
    {
        float resultadoCirculo = (circuloRadio * circuloRadio) * pi;
        return resultadoCirculo;
    }

    float Convertir(float euroADolar, float dolarAEuro, float areaCirculo)
    {
         
        


        if (moneda == "euro")
        {
            return  areaCirculo * euroADolar;

            
        }
        else if (moneda == "dolar")
        {
            return areaCirculo * dolarAEuro;
            
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
