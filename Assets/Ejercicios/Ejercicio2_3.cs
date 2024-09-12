using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vida = 100;
    float exp = 50;
    // Start is called before the first frame update
    void Start()
    {
        producto();
        cociente();
        resto();
        dobleVidas();
        tripleExp();

    }
    void producto()
    {
        float productoFinal = vida * exp;
        Debug.Log(productoFinal);
    }

    void cociente()
    {
        float cocienteFinal = vida / exp;
        Debug.Log(cocienteFinal);
    }

    void resto()
    {
        float restoFinal = vida % exp;
        Debug.Log(restoFinal);
    }

    void dobleVidas()
    {
        int dobleVidasFinal = vida * 2;
        Debug.Log(dobleVidasFinal);
    }

    void tripleExp()
    {
        float tripleExpFinal = exp * 3;
        Debug.Log(tripleExpFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
