using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumibles : ObjetoInteractivoGenerico
{
    public GameObject CocaCola;

    public override void ActivarAccion()
    {
        if (CocaCola.gameObject.activeInHierarchy)
        {
            CocaCola.gameObject.SetActive(false);
            textoAccion = "Tomar refresco";
        }
    }
}
