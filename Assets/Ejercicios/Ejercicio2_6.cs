using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 85; 
    int puntuacion2 = 90;
    int puntuacion3 = 78;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("puntuaci�n1: " + puntuacion1);
        Debug.Log("puntuaci�n2: " + puntuacion2);
        Debug.Log("puntuaci�n3: " + puntuacion3);

        media();

    }

    void media()
    {
        int suma = puntuacion1 + puntuacion2 + puntuacion3;
        int media = suma / 3;
        Debug.Log("la media es " + media);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
