using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLateral : MonoBehaviour
{
    public GameObject prota;
    private float distancia = 10;
    void Update()
    {
        transform.position = new Vector3(distancia, prota.transform.position.y + 3, prota.transform.position.z);
    }
}
