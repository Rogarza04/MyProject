using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    public int Exp;

    // Start is called before the first frame update
    void Start()
    {
        int Lvl = 32 + (9 * Exp/5);
        Debug.Log(Lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
