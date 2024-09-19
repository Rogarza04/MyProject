using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
   
    [SerializeField] Personaje Sigma;
    [SerializeField] Personaje Skibidi;


    void Start()
    {
        Sigma.Vida = 100;

        Skibidi.Vida = 50;

        Sigma.Mover(3, 0 , -1);

    }

}
