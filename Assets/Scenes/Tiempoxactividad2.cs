using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Tiempoxactividad2 : MonoBehaviour
{
    [SerializeField]
    public bool finnished = false;
    public int actividad;

    public string inicio;
    public string final;
    public int causa;
    public int usuario_id;
    public int reim_id;
    public int actividad_id;

    private void Start()
    {
        inicio = tiempoActual();
    }

    public void salirActividad(int actividad)
    {
        this.actividad_id = actividad;
        this.final = tiempoActual();
        this.reim_id = 666;
        this.usuario_id = Login.user_id;
        this.causa = 0;
        StartCoroutine(add());
    }

    private void Update()
    {
        if (finnished)
        {
            salirActividad(actividad);
            Destroy(gameObject);
            //swit = 0;
        }

    }


    public void Finnish()
    {
        finnished = true;
    }

    public string tiempoActual()
    {
        DateTime ahora = DateTime.Now;
        string fechaActual = ahora.ToString("yyyy-MM-dd HH:mm:ss");
        return fechaActual;
    }

    public IEnumerator add()
    {
        string api = "https://7tv5uzrpoj.execute-api.sa-east-1.amazonaws.com/prod/api";
        string apilocal = "http://localhost:3002/api";
        string URL = api + "/tiempoxactividad/add";

        TiempoxActividadClass2 elemento = new TiempoxActividadClass2();
        elemento.inicio = inicio;
        elemento.final = final;
        elemento.actividad_id = actividad_id;
        elemento.reim_id = reim_id;
        elemento.usuario_id = usuario_id;

        var json = JsonUtility.ToJson(elemento);

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
}

//[Serializable]
public class TiempoxActividadClass2
{

    public string inicio;
    public string final;
    public int causa;
    public int usuario_id;
    public int reim_id;
    public int actividad_id;

}
