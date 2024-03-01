using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuar : MonoBehaviour
{
    private Animator miAnimador;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            miAnimador.SetTrigger("Interactuar");
        }
    }
}
