using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteracticaAnim : ObjetoInteractivoGenerico
{
    private Animator miAnimador;
    private bool estaAbierta = false;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    public override void ActivarAccion()
    {
        if (estaAbierta)
        {//esta abierta, asi que la cierro
            miAnimador.SetTrigger("Cerrar");
            textoAccion = "Abrir puerta";
        }
        else
        {//no esta abierta, asi que la abro
            miAnimador.SetTrigger("Abrir");
            textoAccion = "Cerrar puerta";
        }
        //Asigno el valor opuesto
        estaAbierta = !estaAbierta;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
