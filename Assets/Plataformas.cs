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
    public GameObject getcanvas2;
    public GameObject textotimer;
    public GameObject textoronda;
    public GameObject platprinci;
    [SerializeField] TextMeshProUGUI m_Object;
    public GameObject saveObj;
    //public GameObject btn;
    public bool caido;
    public bool conta;
    public GameObject Tiempo;
    public GameObject moverplat;
    public GameObject letrero;


    int x;
    int z;
    public int count;
    //public float targettime = 10.0f;

    public void iniciarplat()
    {
        getcanvas2.SetActive(false);
        letrero.SetActive(false);
        Tiempo.SetActive(true);
        Instantiate(Tiempo);
        //dataScene.upoints = dataScene.upoints - 100;
        Tiempo.SetActive(false);

        platprinci.SetActive(true);
        //btn.SetActive(false);
        //nxtronda = true;
        count = 0;
        caido = false;
        moverplat.SetActive(true);
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
        
        conta = true;
        count++;
        textoronda.SetActive(true);
        m_Object.text = count.ToString("f0");

        for (int i = 0; i < plataformaspawn.Length; i++)
        {
            plataformaspawn[i].SetActive(true);
            x = Random.Range(0, 5);
            switch (x)
            {
                case 0:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[0];
                    plataformaspawn[i].gameObject.tag = "Vidrio";
                    break;
                case 1:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[1];
                    plataformaspawn[i].gameObject.tag = "Madera";
                    break;
                case 2:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[2];
                    plataformaspawn[i].gameObject.tag = "Carton";
                    break;
                case 3:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[3];
                    plataformaspawn[i].gameObject.tag = "Metal";
                    break;
                case 4:
                    plataformaspawn[i].GetComponent<MeshRenderer>().material = material[4];
                    plataformaspawn[i].gameObject.tag = "Plastico";
                    break;
            }
            plataformasave[i] = plataformaspawn[i].GetComponent<MeshRenderer>().material;


        }

        getcanvas.SetActive(true);
        //z = Random.Range(0, 14);
        while (conta)
        {

            z = Random.Range(0, 14);
            Debug.Log("paso y Z ES: " + z );

            for (int i = 0; i < plataformaspawn.Length; i++)
            {
                if (objetos[z].CompareTag(plataformaspawn[i].gameObject.tag) == true)
                {
                    Debug.Log("Conta falso, ENCONTRO OBJETO Y PLATAFORMA");
                    conta = false;
                    break;
                }
            }
        }

        objetos[z].SetActive(true);
        saveObj = objetos[z];
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




