using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderTV : ObjetoInteractivoGenerico
{
    public GameObject Pantalla;

    public override void ActivarAccion()
    {
        if (Pantalla.gameObject.activeInHierarchy)
        {
            Pantalla.gameObject.SetActive(false);
            textoAccion = "Prender TV";
        }
        else
        {
            Pantalla.gameObject.SetActive(true);
            textoAccion = "Apagar TV";
        }
    }
}
