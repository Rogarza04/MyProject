using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vida = 100;
    float exp = 50;
    char carac = 'a';
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vida);
        Debug.Log(exp);
        sumaVidaExp();
        restaVidaExp();
    }
    void sumaVidaExp()
    {
        float resultadoSuma = vida + exp;
        Debug.Log(resultadoSuma);
    }
    void restaVidaExp()
    {
        float resultadoResta  = exp - vida;
        Debug.Log(resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
