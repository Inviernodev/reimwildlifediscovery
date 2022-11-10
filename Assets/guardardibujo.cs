using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Respuestadibujo
{
    public string sesion_id;
    public int usuario_id;
    public int reim_id;
    public int actividad_id;
    public byte[] imagen;

}

public class Respuestadibujo2
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

public class guardardibujo : MonoBehaviour
{
    public static int elemid;
    // Start is called before the first frame update
    public void ClickGuardado()
    {
        TiempoxActividad.swit = 1;
        agregar_dibujo();
        dataScene.upoints = dataScene.upoints + 50;
        SceneManager.LoadScene("MapaPrincipal"); //aca
    }

    public IEnumerator PostAdd(Respuestadibujo respueston)
    {
        string api = "http://localhost:3002/api";
        string urlAPI = cambiarApiServidor.URL + "/Dibujo_reim/add"; //cambiarApiServidor.URL "http://localhost:3002/api/alumno_respuesta/add";
        var jsonData = JsonUtility.ToJson(respueston);
        //Debug.Log(jsonData);

        using (UnityWebRequest www = UnityWebRequest.Post(urlAPI, jsonData))
        {
            www.SetRequestHeader("content-type", "application/json");
            www.uploadHandler.contentType = "application/json";
            www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(jsonData));
            yield return www.SendWebRequest();

            if (www.isNetworkError)
            {
                Debug.Log(www.error);
                Debug.Log("Error");
            }
            else
            {
                if (www.isDone)
                {
                    var result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
                    //Debug.Log(result);
                    if (result != null)
                    {
                        //var id_txa = JsonUtility.FromJson<String>(result);
                        //Debug.Log(id_txa);
                    }
                }
            }
        }
    }

    public void agregar_correcta()
    {
        Respuestadibujo2 respuestini;
        respuestini = new Respuestadibujo2();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60011;
        respuestini.id_elemento = elemid;
        DateTime ahora = DateTime.Now;
        respuestini.datetime_touch = ahora.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
        respuestini.Eje_X = gameObject.transform.position.x;
        respuestini.Eje_Y = gameObject.transform.position.y;
        respuestini.Eje_Z = gameObject.transform.position.z;
        respuestini.correcta = 1;
        respuestini.resultado = "Guardo Dibujo";
        respuestini.Tipo_Registro = "1";
        StartCoroutine(PostAdd(respuestini));
    }

    public IEnumerator PostAdd(Respuestadibujo2 respueston)
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


    public void agregar_dibujo()
    {
        Respuestadibujo respuestini;
        respuestini = new Respuestadibujo();
        respuestini.usuario_id = Login.user_id;
        respuestini.reim_id = 666;
        respuestini.actividad_id = 60011;
        //dibujo = GetComponent<SpriteRenderer>();
        Sprite sp = Resources.Load<Sprite>("ReadWriteEnabledImage");
        //Sprite sp = gameObject.GetComponent<SpriteRenderer>();
        byte[] bytes = sp.texture.EncodeToPNG();
        //string imgstr = Convert.ToBase64String(bytes);
        respuestini.imagen = bytes;
        //respuestini.imagen = sp;
        DateTime ahora = DateTime.Now;
        respuestini.sesion_id = Login.idSesion;
        StartCoroutine(PostAdd(respuestini));
    }
}
