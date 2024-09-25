using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    // Start is called before the first frame update
    void Start()
    {
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
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
