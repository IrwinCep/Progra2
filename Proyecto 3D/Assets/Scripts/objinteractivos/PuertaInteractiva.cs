using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractiva : ObjetoInteractivoGenerico
{
    public float rotacioAbierto = 0;
    public float rotacionCerrado = 0;
    private bool estaAbierta = false;


    public override void ActivarAccion()
    {
        //Aqui voy a implementar como se
        //abre la puerta
        if (estaAbierta)
        {
            transform.rotation = Quaternion.Euler(0, rotacionCerrado, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, rotacioAbierto, 0);

        }
    }
}
