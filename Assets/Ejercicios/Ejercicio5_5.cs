using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int exp;
    
    // Start is called before the first frame update
    void Start()
    {
        if (exp % 2 == 0)
        {
            Debug.Log("El nivel del personaje es par.");

        }
        else
        {
            Debug.Log("El nivel del personaje es inpar.");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
