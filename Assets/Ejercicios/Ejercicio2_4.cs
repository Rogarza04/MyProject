using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vida = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vida);
        vida += 77;
        Debug.Log(vida);
        vida -= 3;
        Debug.Log(vida);
        vida *= 4;
        Debug.Log(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
