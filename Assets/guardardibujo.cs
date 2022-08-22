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

public class guardardibujo : MonoBehaviour
{
    // Start is called before the first frame update
    public void ClickGuardado()
    {
        TiempoxActividad.swit = 1;
        agregar_dibujo();
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
