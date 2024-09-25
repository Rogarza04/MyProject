using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int num = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (num <= 100)
        {
            num++;
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
