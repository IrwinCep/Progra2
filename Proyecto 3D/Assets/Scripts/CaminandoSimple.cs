using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class CaminandoSimple : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody miCuerpo;
    public float velPerso;
    private Animation miAnimador;

    Vector3 movimiento;
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animation>();
    }
    void Update()
    {
        float movHoriz = Input.GetAxisRaw("Vertical");
        float movVert = Input.GetAxisRaw("Horizontal");
        movimiento = new Vector3(movHoriz, 0, -movVert);
    }

    private void FixedUpdate()
    {
        miCuerpo.MovePosition(transform.position + (movimiento * velPerso * Time.fixedDeltaTime));
    }
}
