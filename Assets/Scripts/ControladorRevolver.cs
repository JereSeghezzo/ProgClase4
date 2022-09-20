using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRevolver : MonoBehaviour
{
    [SerializeField] int tirosTotales;
    [SerializeField] int tirosEnCargador;
    bool Recargando;

    void Start()
    {
      tirosEnCargador = tirosTotales;    
    }

    void Update()
    {
       if (Input.GetMouseButtonDown(1))
       {
        Disparar();   
       }

       if (Input.GetKeyDown("r") && tirosEnCargador != tirosTotales)
       {
        Recargando = true;
        StartCoroutine(RecargarRevolver());
       }

    }

    void Disparar()
    {
     if(Recargando)
        {
         Recargando = false;   
         StopCoroutine(RecargarRevolver());
        }   
      if (tirosEnCargador > 0)
      {
        tirosEnCargador -= 1; 
        Debug.Log("Se disparó un tiro, tiros restantes " + tirosEnCargador);
      }
      if(tirosEnCargador == 0)
      {
        Debug.Log("El arma se quedó sin balas, ahora se está recargando");  
        Recargando = true;
        StartCoroutine(RecargarRevolver());
      }
    }

    IEnumerator RecargarRevolver()
    {
      yield return new WaitForSeconds(1f);  
     if(Recargando)
     {
      tirosEnCargador += 1;
      Debug.Log("Se cargó un tiro, tiros en cargador = " + tirosEnCargador);
      if(tirosEnCargador < tirosTotales)
      {
        StartCoroutine(RecargarRevolver()); 
      }else Recargando = false;
     }
    }


}
