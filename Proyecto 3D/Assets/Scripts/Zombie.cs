using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    private NavMeshAgent cuerpoZ;
    private Animator miAnimador;

    void Start()
    {
        cuerpoZ = GetComponent<NavMeshAgent>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cuerpoZ.velocity.magnitude > 0)
        {
            miAnimador.SetBool("caminando",true);
        }
        else
        {
            miAnimador.SetBool("caminando", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            miAnimador.SetTrigger("atacar");
        }
    }
}
