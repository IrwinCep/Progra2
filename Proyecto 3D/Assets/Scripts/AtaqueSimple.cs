using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueSimple : MonoBehaviour
{
    private Animator miAnimador;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            miAnimador.SetTrigger("Atacar");
        }
    }
}
