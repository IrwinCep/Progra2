using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    //Esta instancia es mi "singleton"
    //de controlador ui
    public static ControladorUI Instancia;
    public GameObject grupoPrompt;
    public Text etiquetaAccion;

    public void MostrarInteraccionConObj(
            ObjetoInteractivoGenerico elObj)
    {
        if(elObj != null)
        {//El objeto no es vacio, asi que muestro
            etiquetaAccion.text = elObj.textoAccion;
            grupoPrompt.SetActive(true);
        }
        else
        {//el objeto ws vacio, asi que oculto
            grupoPrompt.SetActive(false);
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        Instancia = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
