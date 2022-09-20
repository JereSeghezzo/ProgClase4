using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDado : MonoBehaviour
{
    public Text nombreModificador;
    public Text bonoTotal;
    public Text textoBotonBono;

    [SerializeField] int cantidadDeCaras;
    [SerializeField] int cantidadBono;
    [SerializeField] bool bono;
    int caraResultante;
    [SerializeField] string Bono1;

    void Start()
    {
      bono = false;
      textoBotonBono.text = Bono1; 
    }

    void Update()
    {
        
    }

    public void LanzarDado()
    {
      caraResultante = Random.Range(1,cantidadDeCaras + 1);
      if(bono)
      {
       caraResultante += cantidadBono;
       bonoTotal.text = "Bono total de +"+ cantidadBono.ToString(); 
      }else bonoTotal.text = "Bono total de +0";

      Debug.Log("La cara resultante fue "+caraResultante);
    }

    public void ToggleBono()
    {
     bono = !bono;
     if(bono)
     {
      nombreModificador.text = Bono1;
     }
     else
     {
      nombreModificador.text = "";
     }
    }
}
