using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre;
    private float vida;
    private float danho;
    private float velocidad;

    public float Vida { get => vida; set => vida = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Danho { get => danho; set => danho = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }

     public void Mover(float x, float y, float z)
    {

    }

    public void Atacar()
    {

    }

    public void Saltar()
    {

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
