using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using System;

[AddComponentMenu("FusionWater/_Examples/BoatController")]

//[Serializable]
public class Respuestachoq
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

public class BoatController : MonoBehaviour
{

    [SerializeField]
    public ParticleSystem particulaVapor;
    [SerializeField]
    public ParticleSystem particulaChoque;
   

    public float moveSpeed = 10f;
    public float turnSpeed = 10f;

    [Range(0.5f, 5)]
    public float accelerationTime = 3f;
    private float accTime = 0;

    public AnimationCurve accelerationCurve;

    public Transform boatMotor;
    private Vector3 startRotation;

    private Rigidbody rb;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Terrain")
        {
            particulaChoque.Play();
            agregar_correcta();
            Debug.Log("Choco: ");
        }
    }


    public IEnumerator PostAdd(Respuestachoq respueston)
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
        Respuestachoq respuestini;
        respuestini = new Respuestachoq();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60008;
        respuestini.id_elemento = 6660106;
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

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        startRotation = boatMotor.localEulerAngles;
    }

    void FixedUpdate()
    {
        float moveInput = -Input.acceleration.z;
        float turnInput = Input.acceleration.x;

        if (moveInput == 0)
        {
            accTime = 0;
        }
        else
        {
            accTime += Time.fixedDeltaTime;
        }
            

        float accelerationFactor = 1 / accelerationTime;
        float acceleration = accelerationCurve.Evaluate(accTime * accelerationFactor);

        //Add Force at Boat Motors Position
        if (moveInput < 0.55)
        {
            particulaVapor.Stop();
            moveInput = moveInput - 0.55f;
            rb.AddForceAtPosition(moveInput * acceleration * moveSpeed * boatMotor.forward, boatMotor.position);
        }
        else
        {
            particulaVapor.Play();
            rb.AddForceAtPosition(moveInput * acceleration * moveSpeed * boatMotor.forward, boatMotor.position);
        }
        

        //Rotate the Motor itself (subtract: Motor turning left = Boat turning right)
        boatMotor.localEulerAngles = startRotation;
        boatMotor.Rotate(Vector3.right, turnInput * turnSpeed, Space.Self);
    }
}
