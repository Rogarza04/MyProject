using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo == 1) 
        {
            Debug.Log("Tiene daño 350 y vida 650");
        }
        else if (tipo == 2) 
        {
            Debug.Log("Tiene daño 300 y vida 550");
        }
        else if (tipo == 3)
        {
            Debug.Log("Tiene daño 300 y vida 500");
        }
        else if (tipo == 4)
        {
            Debug.Log("Tiene daño 310 y vida 460");
        }
        else if (tipo == 5)
        {
            Debug.Log("Tiene daño 280 y vida 490");
        }
        else if (tipo == 6)
        {
            Debug.Log("Tiene daño 360 y vida 520");
        }
        else
        {
            Debug.Log("Pon un num del 1 al 6");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
