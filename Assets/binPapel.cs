using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;

[Serializable]

public class Respuesta
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
            dataScene.upoints = dataScene.upoints + 20; // aca

            agregar_correcta(); //aca
            if (actividadReciclaje.cont == ScoreCounter.basuraValue)
            {
                // Inicio - mismo codigo en otros papeleros
                GetCanvas.SetActive(false);
                dataScene.upoints = dataScene.upoints + ScoreCounter.scoreValue;
                TiempoxActividad.swit = 1;
                SceneManager.LoadScene("MapaPrincipal"); //aca
                
                
                // Final
            }
        }
        else
        {
            agregar_incorrecta(); // aca
            Destroy(other.gameObject);
            actividadReciclaje.showB = false;
            actividadReciclaje.cont++;
            actividadReciclaje.imagenActiva.SetActive(false);
            if (actividadReciclaje.cont == ScoreCounter.basuraValue)
            {
                GetCanvas.SetActive(false);
                dataScene.upoints = dataScene.upoints + ScoreCounter.scoreValue;
                TiempoxActividad.swit = 1;
                SceneManager.LoadScene("MapaPrincipal"); //aca
            }
        }
    }

    public IEnumerator PostAdd(Respuesta respueston)
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
        Respuesta respuestini;
        respuestini = new Respuesta();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60008;
        respuestini.id_elemento = 6660102;
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
        Respuesta respuestini;
        respuestini = new Respuesta();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60008;
        respuestini.id_elemento = 6660102;
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


}
