using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoCruz : MonoBehaviour
{
    private Rigidbody miCuerpo;
    private Animator miAnimador;
    public float velocidadCaminar = 5;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        miAnimador.SetFloat("Despl_Lat", horizontal);

        miAnimador.SetFloat("Despl_Front", vertical);

        miCuerpo.velocity = (transform.forward * vertical *velocidadCaminar) + (transform.right * horizontal * velocidadCaminar);


    }
}
