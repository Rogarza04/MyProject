using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public  float danhoMinimo;
    public  float danhoMaximo;
    [SerializeField] private int capacidadTotal;
    [SerializeField] private bool esAutomatica;
    private int municionActual;

    public int UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual--;
            return 0;
        }
        return -1;
    }

    public int RecargarArma()
    {
        if (municionActual < capacidadTotal)
        {
            municionActual = capacidadTotal;
            return 0;
        }
        return -1;
    }


    // Start is called before the first frame update
    void Start()
    {
        municionActual = capacidadTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
