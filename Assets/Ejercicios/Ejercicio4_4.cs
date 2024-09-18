using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float velocidadKmH;

    // Start is called before the first frame update
    void Start()
    {
       float ms = Conversor(1000, 3600);
       Debug.Log(velocidadKmH + "Km/H son " + ms + "m/s");
    }

    float Conversor(float metros, float segundos)
    {
        float transformVelocidad = velocidadKmH / metros * segundos;
        return transformVelocidad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
