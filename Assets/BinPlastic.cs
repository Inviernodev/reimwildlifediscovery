using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinPlastic : MonoBehaviour
{
    [SerializeField]
    public GameObject GetCanvas;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Botella(Clone)" || other.gameObject.name == "Contenedor(Clone)" || other.gameObject.name == "Guantes(Clone)" || other.gameObject.name == "Bolsas(Clone)" || other.gameObject.name == "Jeringas(Clone)")
        {
            actividadReciclaje.reci += 1;
            Destroy(other.gameObject);
            actividadReciclaje.showB = false;
            actividadReciclaje.cont++;
            actividadReciclaje.imagenActiva.SetActive(false);
            if (actividadReciclaje.cont == ScoreCounter.basuraValue)
            {
                GetCanvas.SetActive(false);
                Debug.Log("end");

            }
        }
        else
        {
            Debug.Log("Fallo");
        }
    }
}
