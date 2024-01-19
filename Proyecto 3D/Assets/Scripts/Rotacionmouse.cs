using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionmouse : MonoBehaviour
{
    public float velocidadRot = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movHoriz = Input.GetAxis("Mouse X");
        transform.Rotate(
            transform.up * movHoriz * velocidadRot, Space.Self);
    }
}
