using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oroSegundos = 7;
    int segundosHora = 3600;
    int horas = 4;
   
    void Start()
    {
        int totalSegundos = horas * segundosHora;
        int oroTotal = oroSegundos * totalSegundos;
        Debug.Log("El oro total es " + oroTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
