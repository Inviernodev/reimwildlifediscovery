using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            dataScene.upoints = dataScene.upoints + 100; // aca
            if (actividadReciclaje.cont == ScoreCounter.basuraValue)
            {
                // Inicio - mismo codigo en otros papeleros
                GetCanvas.SetActive(false);
                SceneManager.LoadScene("MapaPrincipal"); //aca
                Debug.Log("end");
                // Final
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
