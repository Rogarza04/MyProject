using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 < 3 && num2 < 3)
        {
            Debug.Log("son menores");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
