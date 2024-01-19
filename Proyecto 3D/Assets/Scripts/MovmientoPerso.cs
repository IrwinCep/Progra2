using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmientoPerso : MonoBehaviour
{
    public float veloPerso;
    private Rigidbody miCuerpo;
    private Animator miAnimador;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float movHoriz = Input.GetAxisRaw("Horizontal");
        float movVert = Input.GetAxisRaw("Vertical");

        miAnimador.SetFloat("Despl_Lat", movHoriz);
        miAnimador.SetFloat("Despl_Front", movVert);

        miCuerpo.velocity = ((transform.forward *movVert + transform.right *movHoriz) *veloPerso)  ; 

    }
}
