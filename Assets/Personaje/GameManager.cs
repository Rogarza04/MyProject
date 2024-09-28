using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Personaje personaje1;
    public Personaje personaje2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonajes();
        }
    }

    void PrepararPersonajes()
    {
        if (personaje1.nombre == null && personaje2.nombre == null)
        {
            personaje1.nombre = "Personaje 1";
            personaje1.vida = 100;
            personaje1.experiencia = 1500;

            personaje2.nombre = "Personaje 2";
            personaje2.vida = 120;
            personaje2.experiencia = 2000;

            Debug.Log(personaje1.nombre + " Nivel: " + personaje1.CalcularNivel());
            Debug.Log(personaje2.nombre + " Nivel: " + personaje2.CalcularNivel());

            personaje1.miTurno = true;
            personaje2.miTurno = false;
        }
    }

    public void FinDeTurno(Personaje personaje)
    {
        if (personaje == personaje1)
        {
            personaje1.miTurno = false;
            personaje2.miTurno = true;
        }
        else
        {
            personaje1.miTurno = true;
            personaje2.miTurno = false;
        }
    }
}
