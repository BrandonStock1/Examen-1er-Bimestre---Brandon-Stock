using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int taxis;
    public int dias;
    public int lluvia;

    // Start is called before the first frame update
    void Start()
    {
        int combustible;
        combustible = 130;
        int total;
        int lluv;
        int resto;
        resto = dias - lluvia;
        lluv = 110 / 15;    // lo redondea a 7 debido a que es un int 
        total = taxis * ((lluvia * (combustible * lluv)) + (resto * (combustible * 6)));
             
        if (dias < 5)
        {
            Debug.Log("Error");
        }
        else if (lluvia < 0)
        {
            Debug.Log("Error");
        }
        else if (lluvia > dias)
        {
            Debug.Log("Error");
        }
        else
        {
            Debug.Log("Una flota de " + taxis + " unidades trabajando durante " + dias + " días implicará un gasto de " + total + " pesos en concepto de combustible");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
