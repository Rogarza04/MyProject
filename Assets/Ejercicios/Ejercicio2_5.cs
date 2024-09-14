using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 70;
    int vidasPlayer2 = 20;
    int vidasPlayer3 = 50;
    int vidasPlayer4 = 15;

   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidasPlayer1);
        Debug.Log(vidasPlayer2);
        Debug.Log(vidasPlayer3);
        Debug.Log(vidasPlayer4);

        nuevasVidas();

    }

    void nuevasVidas()
    {
        vidasPlayer2 = vidasPlayer3;
        Debug.Log(vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log(vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log(vidasPlayer1);
        vidasPlayer4 = vidasPlayer2;
        Debug.Log(vidasPlayer4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
