using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Plataformas : MonoBehaviour
{
    [SerializeField]
    public GameObject[] plataformaspawn = new GameObject[12];
    public Material[] plataformasave = new Material[12];
    public GameObject[] objetos = new GameObject[15];
    public Material[] material = new Material[5];
    public Material materialdefecto;
    public GameObject getcanvas;
    public GameObject textotimer;
    public GameObject textoronda;
    public GameObject platprinci;
    [SerializeField] TextMeshProUGUI m_Object;
    public GameObject saveObj;
    public GameObject btn;
    public bool caido;


    int x;
    int z;
    int count;
    //public float targettime = 10.0f;

    public void iniciarplat()
    {
        platprinci.SetActive(true);
        btn.SetActive(false);
        //nxtronda = true;
        count = 0;
        caido = false;
        iniciarronda();
        //starttime = time.time;
        //if (time = 10f)
        //{
        //    z = random.range(0, 15);
        //    objetos[z].setactive(true);
        //    defaultplat();
        //}

    }

    public void iniciarronda()
    {
        count++;
        textoronda.SetActive(true);
        m_Object.text = count.ToString("f0");

        for (int i = 0; i < plataformaspawn.Length; i++)
        {
            plataformaspawn[i].SetActive(true);
            x = Random.Range(0, 4);
            switch (x)
            {
                case 1:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[0];
                    plataformaspawn[i].gameObject.tag = "Vidrio";
                    break;
                case 2:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[1];
                    plataformaspawn[i].gameObject.tag = "Madera";
                    break;
                case 3:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[2];
                    plataformaspawn[i].gameObject.tag = "Carton";
                    break;
                case 4:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[3];
                    plataformaspawn[i].gameObject.tag = "Metal";
                    break;
                case 5:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[4];
                    plataformaspawn[i].gameObject.tag = "Plastico";
                    break;
            }
            plataformasave[i] = plataformaspawn[i].GetComponent<MeshRenderer>().material;


        }
        getcanvas.SetActive(true);
        z = Random.Range(0, 14);
        objetos[0].SetActive(true);
        saveObj = objetos[0];
        //saveObj.gameObject.tag = "Vidrio";
        textotimer.SetActive(true);
        //se termina el tiempo y vuelven las plataformas a su defecto

        
        //spawn objeto
        //mostrarplat();

        //mostrar y caer plataformas
        //siguiente ronda


        //if (seconds = "10")
        //{
        //    z = random.range(0, 15);
        //    objetos[z].setactive(true);
        //    defaultplat();
        //}


    }


    public void defaultplat()
    {
        for (int i = 0; i < plataformaspawn.Length; i++)
        {
            plataformaspawn[i].GetComponent<MeshRenderer>().material = materialdefecto;
        }

    }

    public void mostrarplat()
    {
        for (int p = 0; p < plataformasave.Length; p++)
        {

            plataformaspawn[p].GetComponent<MeshRenderer>().material = plataformasave[p];
        }
    }

    public void caidaplat()
    {
        Debug.Log(saveObj.GetComponent<MeshRenderer>().material);
        for (int i = 0; i < plataformaspawn.Length; i++)
        {
            if (plataformaspawn[i].CompareTag(saveObj.tag) == false) 
            { 
                Debug.Log(plataformaspawn[i].GetComponent<MeshRenderer>().material);
                plataformaspawn[i].SetActive(false); //se cae la plataforma
            }
            //plataformaspawn[i].GetComponent<MeshRenderer>().material = materialdefecto;
        }
    }

    public void backuplat()
    {
        for (int i = 0; i < plataformasave.Length; i++)
        {
            plataformaspawn[i].GetComponent<MeshRenderer>().material = plataformasave[i];
        }
    }


}




