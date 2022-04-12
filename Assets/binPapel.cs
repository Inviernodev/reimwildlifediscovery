using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binPapel : MonoBehaviour
{
    [SerializeField]
    public GameObject GetCanvas;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Caja(Clone)" || other.gameObject.name == "Libro(Clone)" || other.gameObject.name == "Envases(Clone)" || other.gameObject.name == "Rollos(Clone)" || other.gameObject.name == "Diario(Clone)")
        {
            actividadReciclaje.reci += 1;
            Destroy(other.gameObject);
            actividadReciclaje.showB = false;
            actividadReciclaje.cont++;
            actividadReciclaje.imagenActiva.SetActive(false);
            if (actividadReciclaje.cont == ScoreCounter.basuraValue)
            {
                // Inicio - mismo codigo en otros papeleros
                GetCanvas.SetActive(false);
                Debug.Log("end");
                // Final
            }
        }
        else
        {
            // Inicio Registrar Fallos
            Debug.Log("Fallo");
            // Fin 
        }
    }
    //actividadReciclaje actre = new actividadReciclaje();
    //int x;
    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.name == "Lata" || other.gameObject.name == "TuercasyTornillos")
    //    {
    //        x = Random.Range(0, 2);
    //        actividadReciclaje.reci += 1;
    //        Destroy(other.gameObject);

    //        actre.Prefabs[x].SetActive(true);
    //    }
    //    else
    //    {
    //        Debug.Log("Fallo");
    //    }
    //}
}
