using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class binMetal : MonoBehaviour
{
    [SerializeField]
    public GameObject GetCanvas;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Lata(Clone)" || other.gameObject.name == "TuercasyTornillos(Clone)" || other.gameObject.name == "Herramientas(Clone)" || other.gameObject.name == "Sarten(Clone)" || other.gameObject.name == "Cable(Clone)")
        {
            actividadReciclaje.reci += 1;
            Destroy(other.gameObject);
            actividadReciclaje.showB = false;
            actividadReciclaje.cont++;
            actividadReciclaje.imagenActiva.SetActive(false);
            dataScene.upoints = dataScene.upoints + 100; // aca
            if (actividadReciclaje.cont == ScoreCounter.basuraValue)
            {
                GetCanvas.SetActive(false);
                SceneManager.LoadScene("MapaPrincipal"); //aca
                Debug.Log("end");

            }
        }
        else
        {
            Destroy(other.gameObject);
            actividadReciclaje.showB = false;
            actividadReciclaje.cont++;
            actividadReciclaje.imagenActiva.SetActive(false);
            if (actividadReciclaje.cont == ScoreCounter.basuraValue)
            {
                GetCanvas.SetActive(false);
                SceneManager.LoadScene("MapaPrincipal"); //aca
                Debug.Log("end");
            }
        }
    }
}
