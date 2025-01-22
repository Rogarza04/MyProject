using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asaas : MonoBehaviour
{
    void Start()
    {
        
        // Declarar e inicializar una lista
        List<int> numeros = new List<int>() { 0, 1, 2, 5, 9, 4 };
        // Añadir elementos
        
        numeros.Add(5);
        numeros.Add(9);
        numeros.Add(4);

       
        Debug.Log("Añadido número: " + numeros[4]);

        // Eliminar un elemento
        numeros.Remove(2);
    }
}
