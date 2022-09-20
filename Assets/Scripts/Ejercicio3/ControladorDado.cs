using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDado : MonoBehaviour
{
    Text resultadoDadoText;
    Text bonoTotalText;

    [SerializeField] int cantidadDeCaras;
    int caraResultante;
    int bonoTotal;
    int resultadoDadoConBono;

    BonoScript bono1;
    BonoScript bono2;
    BonoScript bono3;

    void Start()
    {
     resultadoDadoText = GameObject.Find("ResultadoDado").GetComponent<Text>();
     bonoTotalText = GameObject.Find("BonoTotal").GetComponent<Text>();

     bono1 = GameObject.Find("Bono1").GetComponent<BonoScript>();
     bono2 = GameObject.Find("Bono2").GetComponent<BonoScript>();
     bono3 = GameObject.Find("Bono3").GetComponent<BonoScript>();
    }

    public void LanzarDado()
    {
      bonoTotal = bono1.valorReal + bono2.valorReal + bono3.valorReal;
      caraResultante = Random.Range(1,cantidadDeCaras + 1);
      resultadoDadoConBono = caraResultante + bonoTotal;
      resultadoDadoText.text = "Resultado Dado = "+ resultadoDadoConBono;
      bonoTotalText.text = "Bono Total = " + bonoTotal;

      Debug.Log("Valor dado= "+caraResultante+" Valor bono= "+bonoTotal+" Valor total= "+resultadoDadoConBono);
    }
}
