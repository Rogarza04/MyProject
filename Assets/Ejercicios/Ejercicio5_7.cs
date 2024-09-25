using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int v1;
    [SerializeField] int v2; 
    [SerializeField] int v3;


    // Start is called before the first frame update
    void Start()
    {
        if (v1 >= v2 && v1 >= v3)
        {
            Debug.Log("Jugador 1 ataca primero");
        }
        else if (v2 >= v1 && v2 >= v3)
        {
            Debug.Log("Jugador 2 ataca");
        }
        else
        {
            Debug.Log("Jugador 3 ataca primero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
