using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    public float baseTri;
    public float altTri;


    // Start is called before the first frame update
    void Start()
    {
        float areaTri = (baseTri * altTri) / 2;
        Debug.Log("El area del triangulo es de: " + areaTri);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
