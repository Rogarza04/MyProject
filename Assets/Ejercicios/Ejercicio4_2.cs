using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    [SerializeField] string nom;
    [SerializeField] string apel1;
    [SerializeField] string apel2;
    [SerializeField] int ed;


    void Start()
    {
        string resultado = ConstruirNombre(nom, apel1, apel2, ed);

    }

    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        return "La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " años";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
