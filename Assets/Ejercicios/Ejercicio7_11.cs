using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    int num = 1;

    // Start is called before the first frame update
    void Start()
    {
        int i = 1;

        while (i <= 10)
        {
            Debug.Log(num + " x " + i + " = " + (num * i));
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
