using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int num1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (num1 <0 && num1 >9)
        {
            Debug.Log("está entre 0 y 9");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
