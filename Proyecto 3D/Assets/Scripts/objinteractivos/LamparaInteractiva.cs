using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaInteractiva : ObjetoInteractivoGenerico
{
    public Light laLuz;
    public override void ActivarAccion()
    {
        //Aqui voy a definir como
        //se prende una lampara
        if (laLuz.gameObject.activeInHierarchy)
        {
            laLuz.gameObject.SetActive(false);
            textoAccion = "Encender luz";
        }
        else
        {
            laLuz.gameObject.SetActive(true);
            textoAccion = "Apagar Luz";
        }


        laLuz.gameObject.SetActive(true);
    }
 }