using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class actividadReciclaje: MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    [SerializeField]
    private Text recicladosText;
    public static int reci;
    public static bool showB = false;
    public GameObject basura;
    public static int cont;
    public GameObject GetCanvas;

    public int z;
    public static GameObject imagenActiva;

    public GameObject[] Presprites = new GameObject[40];
    public GameObject[] Prefabs = new GameObject[17];

    void Start()
    {
        if (ScoreCounter.basuraValue == 0)
        {
            GetCanvas.SetActive(false);
            Debug.Log("end");//llamada a script texto que diga Continuar y estadisticas
            TiempoxActividad.swit = 1;
            SceneManager.LoadScene("MapaPrincipal");
        }

    }

    void Update()
    {

        if (showB == false)
        {
            int x = Random.Range(0, 17);
            basura = Instantiate(Prefabs[x], new Vector3(338, 28, 104), Quaternion.identity);
            showB = true;
            switch (x)
            {
                case 0:
                    //lata
                    z = Random.Range(0, 3);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 1:
                    //Tuercas
                    z = Random.Range(3, 6);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 2:
                    //Cable
                    z = Random.Range(6, 9);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 3:
                    //Sarten
                    z = Random.Range(9, 12);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 4:
                    //Herramientas
                    z = Random.Range(12, 15);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 5:
                    //Caja
                    z = Random.Range(15, 18);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 6:
                    //Libro
                    z = Random.Range(18, 20);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 7:
                    //Envases
                    z = Random.Range(20, 22);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 8:
                    //rollos
                    z = Random.Range(22, 24);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 9:
                    //diario
                    z = Random.Range(24, 26);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 10:
                    //Botella
                    z = Random.Range(26, 28);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 11:
                    //Contenedor
                    z = Random.Range(28, 30);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 12:
                    //Guantes
                    z = Random.Range(30, 32);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 13:
                    //Bolsas
                    z = Random.Range(32, 34);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 14:
                    //Jeringas
                    z = Random.Range(34, 36);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 15:
                    //vidrio
                    z = Random.Range(36, 38);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

                case 16:
                    //Comida
                    z = Random.Range(38, 40);
                    Presprites[z].SetActive(true);
                    imagenActiva = Presprites[z];
                    break;

            }

        }


        //    
        //    myPrefab.name = materiales[x];
        //    Debug.Log(myPrefab.name);
        //    Debug.Log("aaaaa");
        //}

        recicladosText.text = "Reciclados: " + reci + "/" + ScoreCounter.basuraValue;
    }
}
