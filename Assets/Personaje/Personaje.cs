using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public string nombre;
    public float vida;
    public float experiencia;
    [SerializeField] Personaje enemigo;
    public SistemaVida miSistemaDeVidas;
    public Arma miArma;
    public KeyCode teclaCura;
    public KeyCode teclaDanho;
    public KeyCode teclaRecargar;
    public bool miTurno;


    public float CalcularNivel()
    {
        return experiencia / 1000;
    }


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (miTurno)
        {
            if (Input.GetKeyDown(teclaCura))
            {
                miSistemaDeVidas.RecibirCura(20);
            }
            if (Input.GetKeyDown(teclaDanho))
            {
                if (miArma.UtilizarArma() == 0)
                {
                    float danho = Random.Range(miArma.danhoMinimo, miArma.danhoMaximo);
                    enemigo.miSistemaDeVidas.RecibirDanho(danho);
                }
                else
                {
                    Debug.Log("Reload!!!");
                }
            }
            if (Input.GetKeyDown(teclaRecargar))
            {
                if (miArma.RecargarArma() == -1)
                {
                    Debug.Log("Arma ya cargada");
                }
            }
        }
    }

}
