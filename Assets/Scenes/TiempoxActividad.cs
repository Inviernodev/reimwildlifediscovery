using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class TiempoxActividad : MonoBehaviour
{
    [SerializeField]
    public static int swit;
    public int actividad;

    public string inicio;
    public string final;
    public int causa;
    public int usuario_id;
    public int reim_id;
    public int actividad_id;

    private void Start()
    {
        swit = 0;
        inicio = tiempoActual();
    }

    public void salirActividad(int actividad) {
        this.actividad_id = actividad;
        this.final = tiempoActual();
        this.reim_id = 666;
        this.usuario_id = Login.user_id;
        this.causa = 0;
        StartCoroutine(add());
    }

    private void Update()
    {
        if(swit==1){
            salirActividad(actividad);
            //swit = 0;
        }

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

        TiempoxActividadClass elemento = new TiempoxActividadClass();
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

[Serializable]
public class TiempoxActividadClass {

    public string inicio;
    public string final;
    public int causa;
    public int usuario_id;
    public int reim_id;
    public int actividad_id; 

}
