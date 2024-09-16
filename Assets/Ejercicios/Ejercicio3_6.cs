using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    public float coche1;
    public float coche2;


    // Start is called before the first frame update
    void Start()
    {

        float velmps1 = coche1 * 1000 / 3600;
        Debug.Log("la velocidad del coche 1 en m/s es:" +  velmps1);

        float velmps2 = coche2 * 1000 / 3600;
        Debug.Log("la velocidad del coche 2 en m/s es:" + velmps2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
