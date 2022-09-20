using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonoScript : MonoBehaviour
{
    [SerializeField] string bonoNombre;
    [SerializeField] int bonoModificador;
    [SerializeField] bool bonoActivo;
    public int valorReal;

    ControladorDado controladorDado;
    public Text nombre;

    void Start()
    {
      controladorDado = GameObject.Find("ControladorDado").GetComponent<ControladorDado>();   
      nombre.text = bonoNombre;
    }

    public void BonoActivo()
    {
      bonoActivo = !bonoActivo;  
      if(bonoActivo)
      {
       valorReal = bonoModificador;
      } else valorReal = 0;
    }
}
