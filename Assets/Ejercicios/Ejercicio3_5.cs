using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    public int RadioCirculo;

    // Start is called before the first frame update
    void Start()
    {
        float longitud = 2f * 3.1416f * RadioCirculo;
        Debug.Log("la longitud es: " + longitud);
        float area = 3.1416f * RadioCirculo * RadioCirculo;
        Debug.Log("el area es: " + area);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
