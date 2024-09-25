using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int resultado = SumarTodosLosNumeros(6, 9);
        Debug.Log("La suma de todos los números entre 3 y 7 es: " + resultado);
    }
    int SumarTodosLosNumeros(int num1, int num2)
    {
        int suma = 0;
        int menor;
        int mayor;

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }

        for (int i = menor; i <= mayor; i++)
        {
            suma += i;
        }

        return suma;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
