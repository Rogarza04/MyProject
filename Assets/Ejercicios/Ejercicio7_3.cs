using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int num = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (num >= 1)
        {
            num--;
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
