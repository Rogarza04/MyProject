using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    int num = 17;
    // Start is called before the first frame update
    void Start()
    {
        int resultado = EsNumPrimo(num);
        if (resultado == 1)
        {
            Debug.Log("El n�mero " + num + " es primo.");
        }
        else
        {
            Debug.Log("El n�mero " + num + " no es primo.");
        }
    }
    int EsNumPrimo(int num)
    {
        if (num <= 1)
        {
            return 0;
        }

        // Verificar si el n�mero es divisible por alg�n n�mero entre 2 y num/2
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return 0;
            }
        }

        return 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
