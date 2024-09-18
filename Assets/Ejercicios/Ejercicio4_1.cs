using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float radioCriculo = 4.5f;
    [SerializeField] float baseTri = 6.2f;
    [SerializeField] float altTri = 8.1f;
    [SerializeField] float ladoCuadrado = 5f;
    
    // Start is called before the first frame update
    void Start()
    {

        float areaCirculo = CirculoArea(radioCriculo, 3.1416f);
        Debug.Log("El area del circulo es " + areaCirculo);
        float areaCuadrado = CuadradoArea(ladoCuadrado);
        Debug.Log("El area del cuadrado es " + areaCuadrado);
        float areaTriangulo = TrianguloArea(altTri, baseTri);
        Debug.Log("El area del triangulo es " + areaTriangulo);
    }

    float CirculoArea(float circuloRadio, float pi)
    {
        float resultadoCirculo = (circuloRadio* circuloRadio) * pi;
        return resultadoCirculo;
    }

    float CuadradoArea(float cuadradoLado)
    {
        float resultadoCuadrado = cuadradoLado * cuadradoLado;
        return resultadoCuadrado;
    }

    float TrianguloArea(float trianguloAltura, float trianguloBase)
    {
        float resultadoTriangulo = trianguloAltura * trianguloBase;
        return resultadoTriangulo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
