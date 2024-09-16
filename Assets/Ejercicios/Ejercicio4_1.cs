using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float radioCriculo = 4.5f;
    float baseTri = 6.2f;
    float altTri = 8.1f;
    float ladoCuadrado = 5f;
    float areaCirculo;
    float areaTriangulo;
    float areaCuadrado;

    // Start is called before the first frame update
    void Start()
    {
        areaCirculo = (radioCriculo * radioCriculo) * 3.1416f;
        areaCuadrado = (ladoCuadrado * ladoCuadrado);
        areaTriangulo = (altTri * baseTri) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
