using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System;
[Serializable]
public class Usuario
{
    public string id;
    public string loginame;
    public string password;
    public int nombre;
}

public class Login : MonoBehaviour
{
    
    public InputField userInput;
    public InputField passwordInput;
    public static int user_id;
    static public string idSesion;
    public IEnumerator Post(Usuario usuario)
    {
        string urlAPI = cambiarApiServidor.URL + "/login";//cambiarApiservidor = https://7tv5uzrpoj.execute-api.sa-east-1.amazonaws.com/prod/api
        var jsonData = JsonUtility.ToJson(usuario);

        using (UnityWebRequest www = UnityWebRequest.Post(urlAPI,jsonData))
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
                if(www.isDone)
                {
                    var result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
                    if(result!=null)
                    {
                        var usuarios = JsonUtility.FromJson<Usuario>(result);
                        string[] a = result.ToString().Split(',');
                        string id_user_aux = a[0];
                        string[] b = id_user_aux.Split(':');
                        string id_user = b[1];
                        user_id = int.Parse(id_user);
                        Debug.Log(user_id); // mod
                        Sesion sesion = new Sesion(user_id);
                        idSesion = sesion.sesion_id;
                        StartCoroutine(CreaSesion(sesion));
                        //Conexiones.id_user = id_user;
                        //Debug.Log(Conexiones.id_user);
                        SceneManager.LoadScene("MapaPrincipal");
                    }
                }
            }
        }
    }

    IEnumerator CreaSesion(Sesion sesion)
    {
        string api = "https://7tv5uzrpoj.execute-api.sa-east-1.amazonaws.com/prod/api";
        string api2 = "http://localhost:3002/api";
        string URL = api + "/asigna_reim_alumno/add";
        var json = JsonUtility.ToJson(sesion);
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
                    //Debug.Log(result);
                }
            }
        }
    }

    public void Logearse()
    {
        Usuario usuario;
        usuario = new Usuario();
        usuario.loginame = userInput.GetComponent<InputField>().text;
        //Conexiones.nickname_user = usuario.loginame;
        usuario.password = passwordInput.GetComponent<InputField>().text;
        StartCoroutine(Post(usuario));
    }
}