using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class dataScene : MonoBehaviour
{
    public static dataScene Instance;
    public static bool estadop1;
    public static bool estadop2;
    public static bool estadop3;
    public static bool estadoi1;
    public static bool estadoi2;
    public static bool estadoi3;
    public static int skin;
    public static int upoints;
    public static bool estadob1;
    public static bool estadob2;
    public static bool estadob3;
    public static bool estadob4;
    public static bool estadob5;
    public static bool estadob6;
    public static bool estadob7;
    public static bool estadob8;
    public static bool estadob9;
    public static bool estadob10;
    public static int contador;
    public GameObject getCanvas;

    // Any data you want this script to have


    // initialize the Singleton instance
    private void Start()
    {
        Debug.Log(Login.user_id);
        Screen.SetResolution(800, 480, true);
        //Estados puentes
        estadop1 = true;
        estadop2 = true;
        estadop3 = true;
        estadoi1 = false;
        estadoi2 = false;
        estadoi3 = false;
        skin = 0;
        contador = 0;
        upoints = 0;
        estadob1 = true;
        estadob2 = true;
        estadob3 = true;
        estadob4 = true;
        estadob5 = true;
        estadob6 = true;
        estadob7 = true;
        estadob8 = true;
        estadob9 = true;
        estadob10 = true;

    }

    private void Update()
    {
        if (contador == 10)
        {
            getCanvas.SetActive(true);
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null)
        {
            Instance = this;

            // Carry over from one scene to the next
           //ontDestroyOnLoad(Instance.gameObject);
        }
        else
        {
            DestroyObject(gameObject);
        }
    }

    public void UpdateARA()
    {
        Sesion a;
        a = new Sesion();
        a.datetime_termino = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        //Debug.Log($"final/{Session}");
        StartCoroutine(Post2(a, $"final/{Login.idSesion}"));
    }

    void OnApplicationQuit()
    {
        UpdateARA();
    }

    //void OnApplicationPause()
    //{
    //    UpdateARA();
    //}

    public IEnumerator Post2(Sesion a, string extend)
    {
        Debug.Log("PASOOOOOOOOOOOOOOOO");
        string urlAPI = "https://7tv5uzrpoj.execute-api.sa-east-1.amazonaws.com/prod/api" + "/asigna_reim_alumno/" + extend; //"http://localhost:3002/api/asigna_reim_alumno/" + extend;
        //Debug.Log("urlPI: "+urlAPI);

        var jsonData = JsonUtility.ToJson(a);
        using (UnityWebRequest www = UnityWebRequest.Post(urlAPI, jsonData))
        {
            www.SetRequestHeader("content-type", "application/json");
            www.uploadHandler.contentType = "application/json";
            www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(jsonData));
            yield return www.SendWebRequest();

            if (www.isNetworkError)
            {
                Debug.Log(www.error);
                Debug.Log("error!");
            }
            else
            {
                if (www.isDone)
                {
                    //Debug.Log("Se actualizo correctamente"+ extend);
                    var result = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
                    //Debug.Log(result);
                    if (result != null)
                    {
                        if (extend == "add")
                        {
                            //Debug.Log("Session: "+Session);
                            //Session = result;
                        }
                        //var asignaRA = JsonUtility.FromJson<AsignaInicio>(result);
                        //
                    }
                }
            }
        }
    }

}