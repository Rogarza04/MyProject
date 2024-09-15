using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Numero: " +  num);
        int doble = num * 2;
        Debug.Log("Numero * 2: " + doble);
        int triple = num * 3;
        Debug.Log("Numero * 2: " + triple);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
