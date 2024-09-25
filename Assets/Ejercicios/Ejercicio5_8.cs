using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int Ho = 2;
    [SerializeField] int Mi = 3; 
    [SerializeField] int Se = 4;
    
    void Start()
    {
        if (Ho >= 0 && Ho < 24 && Mi >= 0 && Mi < 60 && Se >= 0 && Se < 60)
        {
            Debug.Log("Funciona");

        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
