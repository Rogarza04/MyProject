using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num2 > 0)
        {
            int division = num1 / num2;
            Debug.Log("el resultado es " + division);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
