using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaVida : MonoBehaviour
{
    [SerializeField] private float vidaInicial;
    private float vidaActual;


    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0) return -1;
        vidaActual += cantidad;
        return vidaActual;
    }


    public float RecibirDanho(float danho)
    {
        if (danho < 0) return -1;
        vidaActual -= danho;
        if (vidaActual <= 0) return 0;
        return vidaActual;
    }

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
