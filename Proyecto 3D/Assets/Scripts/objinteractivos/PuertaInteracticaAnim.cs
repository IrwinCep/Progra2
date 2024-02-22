using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteracticaAnim : ObjetoInteractivoGenerico
{
    private bool abierto = false;
    private Animator miAnimador;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }
    public override void ActivarAccion()
    {
        if (abierto == false)
        {
            miAnimador.SetTrigger("ABRIR");
            abierto = true;
            textoAccion = "Cerrar Puerta";

        }

        else
        {
            miAnimador.SetTrigger("CERRAR");
            abierto = false;
            textoAccion = "Abrir Puerta";
        }
    }
}
