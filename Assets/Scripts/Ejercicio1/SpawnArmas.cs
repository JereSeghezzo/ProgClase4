using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnArmas : MonoBehaviour
{
    public Text nombreArma;
    public GameObject[] armas;
    public Transform spawnPointArma;
    int arma_i;
    bool spawnListo;
    int posicionArmaDefecto;
    [SerializeField] string armaPorDefecto;

    void Start()
    {
      armas = Resources.LoadAll<GameObject>("Armas");  
    }

    public void PulsarBoton()
    {
     spawnListo = false; 
     for(int arma_i = 0; arma_i < armas.Length; arma_i++)
     {
        if(armas[arma_i].name == armaPorDefecto)
        {
         posicionArmaDefecto = arma_i;
        }

        if(armas[arma_i].name == nombreArma.text)
        {
         SpawnArma(arma_i);   
         spawnListo = true; 
        } 
     } 
     if(!spawnListo)
     {
       SpawnArma(posicionArmaDefecto);    
     }
    }

    void SpawnArma(int armaSpawneada)
    {
      Debug.Log(armas[armaSpawneada].name + " a sido spawneada/o");
      Instantiate(armas[armaSpawneada], spawnPointArma.position, Quaternion.identity);   
    }
}
