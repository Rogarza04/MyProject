using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6while : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        int i = num;
        while (i >= -num)
        {
            Debug.Log(i);
            i--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
