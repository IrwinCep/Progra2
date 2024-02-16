using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject areaActual;
    public GameObject areaDestino;

    private void OnTriggerEnter(Collider other)
    {//Al entrar en contacto con el telestransportador
        if(other.tag == "Player")
        {
            GameObject player = other.gameObject;
            //Desactivo los objetos actuales,
            //antes de la transicion
            player.SetActive(false);
            areaActual.SetActive(false);

            //Cargo la nueva area y la pongo
            //al centro de la escena
            GameObject nuevaArea = Instantiate(areaDestino);
            nuevaArea.transform.position = Vector3.zero;

            //Libero recursos
            Destroy(areaActual);
            //Localizo el punto en donde voy
            //a colocar a mi player
            PuntoSpawn punto =
                GameObject.FindFirstObjectByType<PuntoSpawn>();

            //coloco al player y lo reactivo
            player.transform.position = punto.transform.position;
            player.SetActive(true);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(
            this.transform.position,
            "T_1_cursor_al");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
