using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminandoDireccional : MonoBehaviour
{
    private Rigidbody miCuerpo;
    private Animator miAnimador;
    public int veloPerso;
    public int rotSuav;

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

        Vector3 direccion = new Vector3(movHoriz, 0, movVert);

        

        if(direccion.magnitude > 0)
        {
            Quaternion nuevRot = Quaternion.LookRotation(direccion);
            transform.rotation = Quaternion.Lerp(transform.rotation, nuevRot, Time.deltaTime * rotSuav);
            miAnimador.SetBool("Caminando",true);
        }
        else
        {
            miAnimador.SetBool("Caminando", false);
        }

        miCuerpo.velocity = ((transform.forward * veloPerso) * direccion.magnitude);
    }
}
