using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSenital : MonoBehaviour
{
    public GameObject prota;
    private float distancia = 10;
    void Update()
    {
        transform.position = new Vector3(prota.transform.position.x, distancia, prota.transform.position.z);
    }
}
