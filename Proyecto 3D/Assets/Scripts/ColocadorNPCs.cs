using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [ExecuteInEditMode]
public class ColocadorNPCs : MonoBehaviour
{
    private GameObject[] puntosSpawn;

    void Awake()
    {
        print("despertando");
        puntosSpawn = GameObject.FindGameObjectsWithTag("SpawnNPC");
    }

    // Update is called once per frame
    private void OnDrawGizmos()
    {
        if (puntosSpawn == null)
        {//No hago nada aun
            return;
        }
        Gizmos.color = Color.yellow;
        foreach (GameObject punto in puntosSpawn)
        {
            Gizmos.DrawIcon(punto.transform.position, "T_8_silhouette");
        }
    }

    public void NPCGenerado(GameObject generador, GameObject npc)
    {
        print("Se genero un nuevo NPC " + npc.name);

        //Obtengo un punto aleatorio de mi lista
        GameObject puntoAleatorio = puntosSpawn[Random.Range(0, puntosSpawn.Length)];

        //Coloco el nuevo NPC en la posicion del punto
        npc.transform.position = puntoAleatorio.transform.position;

        AsignadorDestinoNavegacion asignador =
            npc.GetComponent<AsignadorDestinoNavegacion>();

        if (asignador != null)
        {
            asignador.destino = this.transform;
        }
    }
}
