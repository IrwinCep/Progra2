using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaInteractiva : ObjetoInteractivoGenerico
{
 
    private bool encender = false;
    public Light laLuz;

    public override void ActivarAccion()
    {

        if (encender == false)
        {
            laLuz.gameObject.SetActive(true);
            encender = true;
            textoAccion = "Pausar video";
        }

        else
        {
            laLuz.gameObject.SetActive(false);
            encender = false;

            textoAccion = "Grabar video";
        }
    }
}
