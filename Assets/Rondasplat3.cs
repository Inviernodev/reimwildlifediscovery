using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System;


public class Respuestarondas
{
    public int id_per;
    public int id_user;
    public int id_reim;
    public int id_actividad;
    public int id_elemento;
    public string datetime_touch;
    public float Eje_X;
    public float Eje_Y;
    public float Eje_Z;
    public int correcta;
    public string resultado;
    public string Tipo_Registro;
}


public class Rondasplat3 : MonoBehaviour
{
    public int elemid;
    public Plataformas plat;
    public float targettime = 5.0f;
    [SerializeField] TextMeshProUGUI m_Object;
    public GameObject textotimer;
    public GameObject letrero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targettime -= Time.deltaTime;
        m_Object.text = targettime.ToString("f0");
        if (targettime <= 0.0f)
        {
            timerended();
        }

    }

    void timerended()
    {
        
        if (plat.saveObj.tag == "Madera")
        {
            elemid = 6660108;
        }else if(plat.saveObj.tag == "Vidrio")
        {
            elemid = 6660109;
        }
        else if (plat.saveObj.tag == "Metal")
        {
            elemid = 6660110;
        }
        else if (plat.saveObj.tag == "Plastico")
        {
            elemid = 6660111;
        }
        else if (plat.saveObj.tag == "Carton")
        {
            elemid = 6660112;
        }

        if (plat.caido == false)
        {
            agregar_correcta();
            plat.iniciarronda();
        }
        else
        {
            //dar recompensas por rondas
            dataScene.upoints = dataScene.upoints + 20 * plat.count;
            //plat.btn.SetActive(true);
            agregar_incorrecta();
            agregar_rondas();
            letrero.SetActive(true);
            GameObject.FindWithTag("Tiempo2").SendMessage("Finnish");
        }
        textotimer.SetActive(false);
        targettime = 5.0f;

    }


    public IEnumerator PostAdd(Respuestarondas respueston)
    {
        string api = "https://7tv5uzrpoj.execute-api.sa-east-1.amazonaws.com/prod/api";
        string apilocal = "http://localhost:3002/api";
        string URL = api + "/alumno_respuesta/add";

        var json = JsonUtility.ToJson(respueston);
        using (UnityWebRequest www = UnityWebRequest.Post(URL, json))
        {
            www.SetRequestHeader("content-type", "application/json");
            www.uploadHandler.contentType = "application/json";
            www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(json));
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(www.error);
            }
            else
            {
                var result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
                if (www.isDone)
                {
                    Debug.Log(result);
                }
            }
        }
    }


    public void agregar_correcta()
    {
        Respuestarondas respuestini;
        respuestini = new Respuestarondas();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60009;
        respuestini.id_elemento = elemid;
        DateTime ahora = DateTime.Now;
        respuestini.datetime_touch = ahora.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
        respuestini.Eje_X = gameObject.transform.position.x;
        respuestini.Eje_Y = gameObject.transform.position.y;
        respuestini.Eje_Z = gameObject.transform.position.z;
        respuestini.correcta = 1;
        respuestini.resultado = "No aplica";
        respuestini.Tipo_Registro = "1";
        StartCoroutine(PostAdd(respuestini));
    }

    public void agregar_incorrecta()
    {
        Respuestarondas respuestini;
        respuestini = new Respuestarondas();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60009;
        respuestini.id_elemento = elemid;
        DateTime ahora = DateTime.Now;
        respuestini.datetime_touch = ahora.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
        respuestini.Eje_X = gameObject.transform.position.x;
        respuestini.Eje_Y = gameObject.transform.position.y;
        respuestini.Eje_Z = gameObject.transform.position.z;
        respuestini.correcta = 0;
        respuestini.resultado = "No aplica";
        respuestini.Tipo_Registro = "0";
        StartCoroutine(PostAdd(respuestini));
    }
    
    
    //CAMBIAR CUANDO SEA NECESARIO
    public void agregar_rondas()
    {
        Respuestarondas respuestini;
        respuestini = new Respuestarondas();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60009;
        respuestini.id_elemento = 6660113;
        DateTime ahora = DateTime.Now;
        respuestini.datetime_touch = ahora.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
        respuestini.Eje_X = gameObject.transform.position.x;
        respuestini.Eje_Y = gameObject.transform.position.y;
        respuestini.Eje_Z = gameObject.transform.position.z;
        respuestini.correcta = 2;
        respuestini.resultado = plat.count.ToString();
        respuestini.Tipo_Registro = "2";
        StartCoroutine(PostAdd(respuestini));
    }
}
