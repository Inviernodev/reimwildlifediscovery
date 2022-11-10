using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.Networking;
using Random = UnityEngine.Random;

public class Respuestabasuras
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

public class triggerLimpiarBasura : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI btn1;
    public TextMeshProUGUI btn2;
    public TextMeshProUGUI btn3;
    public TextMeshProUGUI preg;
    public TextMeshProUGUI[] btns = new TextMeshProUGUI[3];
    public string resp;
    public string resp2;
    public GameObject basura;
    public GameObject GetCanvas;
    public GameObject Tiempo;
    public TiempoxActividad aaa;
    int z;
    int x;
    public int elemid;
    int basuranumero;
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (!GetCanvas.activeSelf)
        {

            if (other.gameObject.CompareTag("Player") && dataScene.upoints >= 100)
            {
                GetCanvas.SetActive(true);
                Tiempo.SetActive(true);
                Instantiate(Tiempo);
                dataScene.upoints = dataScene.upoints - 100;
                Tiempo.SetActive(false);
                
                x = Random.Range(0, 20); // 0,30
                audioSource = gameObject.GetComponent<AudioSource>();
                audioSource.clip = audioClips[x];
                audioSource.Play();
                

                switch (x)
                {
                    case 0:
                        preg.text = "¿Cuál animal es el más grande entre estos?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Elefante";
                        elemid = 6660120;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Gorila";
                                btn3.text = "Lobo";
                                break;
                            case 1:
                                btn1.text = "Oso polar";
                                btn3.text = "Cocodrilo";
                                break;
                            case 2:
                                btn1.text = "Cocodrilo";
                                btn2.text = "Oso polar";
                                break;
                        }
                        break;
                    case 1:
                        preg.text = "¿En qué hábitat existen glaciares?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Polar";
                        elemid = 6660121;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Desierto";
                                btn3.text = "Bosque";
                                break;
                            case 1:
                                btn1.text = "Montaña";
                                btn3.text = "Jungla";
                                break;
                            case 2:
                                btn1.text = "Jungla";
                                btn2.text = "Bosque";
                                break;
                        }
                        break;
                    case 2:
                        preg.text = "¿En qué hábitat se encuentran gorilas?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Jungla";
                        elemid = 6660122;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Desierto";
                                btn3.text = "Bosque";
                                break;
                            case 1:
                                btn1.text = "Montaña";
                                btn3.text = "Desierto";
                                break;
                            case 2:
                                btn1.text = "Montaña";
                                btn2.text = "Bosque";
                                break;
                        }
                        break;
                    case 3:
                        preg.text = "¿Cuál es el hábitat más seco?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Desierto";
                        elemid = 6660123;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Montaña";
                                btn3.text = "Bosque";
                                break;
                            case 1:
                                btn1.text = "Playa";
                                btn3.text = "Jungla";
                                break;
                            case 2:
                                btn1.text = "Montaña";
                                btn2.text = "Polar";
                                break;
                        }
                        break;

                    case 4:
                        preg.text = "¿Cómo es la cubierta del pingüino?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Grueso";
                        elemid = 6660124;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Delgado";
                                btn3.text = "No tiene";
                                break;
                            case 1:
                                btn1.text = "Delgado";
                                btn3.text = "No tiene";
                                break;
                            case 2:
                                btn1.text = "No tiene";
                                btn2.text = "Delgado";
                                break;
                        }
                        break;

                    case 5:
                        preg.text = "¿Cómo es el pelaje del Lobo?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Grueso";
                        elemid = 6660125;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Delgado";
                                btn3.text = "No tiene";
                                break;
                            case 1:
                                btn1.text = "Delgado";
                                btn3.text = "No tiene";
                                break;
                            case 2:
                                btn1.text = "No tiene";
                                btn2.text = "Delgado";
                                break;
                        }
                        break;
                    case 6:
                        preg.text = "¿Cómo es la cubierta del cocodrilo?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Escamosa";
                        elemid = 6660126;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Plumas";
                                btn3.text = "No tiene";
                                break;
                            case 1:
                                btn1.text = "Pelaje";
                                btn3.text = "Delgado";
                                break;
                            case 2:
                                btn1.text = "No tiene";
                                btn2.text = "Peludo";
                                break;
                        }
                        break;
                    case 7:
                        preg.text = "¿Cuál es más grande?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Gorila";
                        elemid = 6660127;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Ciervo";
                                btn3.text = "Lobo";
                                break;
                            case 1:
                                btn1.text = "Lobo";
                                btn3.text = "Cocodrilo";
                                break;
                            case 2:
                                btn1.text = "Cocodrilo";
                                btn2.text = "Ciervo";
                                break;
                        }
                        break;
                    case 8:
                        preg.text = "¿Cuál es más grande?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Ciervo";
                        elemid = 6660128;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Conejo";
                                btn3.text = "Lobo";
                                break;
                            case 1:
                                btn1.text = "Lobo";
                                btn3.text = "Gaviota";
                                break;
                            case 2:
                                btn1.text = "Lobo";
                                btn2.text = "Águila";
                                break;
                        }
                        break;
                    case 9:
                        preg.text = "¿Cuál es más pequeño?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Conejo";
                        elemid = 6660129;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Ciervo";
                                btn3.text = "Lobo";
                                break;
                            case 1:
                                btn1.text = "Lobo";
                                btn3.text = "Gallina";
                                break;
                            case 2:
                                btn1.text = "Cocodrilo";
                                btn2.text = "Águila";
                                break;
                        }
                        break;
                    case 10:
                        preg.text = "¿Cuál animal no puede volar?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Gallina";
                        elemid = 6660130;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Gaviota";
                                btn3.text = "Águila";
                                break;
                            case 1:
                                btn1.text = "Águila";
                                btn3.text = "Pájaro";
                                break;
                            case 2:
                                btn1.text = "Águila";
                                btn2.text = "Gaviota";
                                break;
                        }
                        break;
                    case 11:
                        preg.text = "¿Cuál animal posee escamas?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Cocodrilo";
                        elemid = 6660131;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Gaviota";
                                btn3.text = "Águila";
                                break;
                            case 1:
                                btn1.text = "Ciervo";
                                btn3.text = "Lobo";
                                break;
                            case 2:
                                btn1.text = "Elefante";
                                btn2.text = "Jirafa";
                                break;
                        }
                        break;
                    case 12:
                        preg.text = "¿Cuál animal posee escamas?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Serpiente";
                        elemid = 6660132;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Gaviota";
                                btn3.text = "Águila";
                                break;
                            case 1:
                                btn1.text = "Ciervo";
                                btn3.text = "Lobo";
                                break;
                            case 2:
                                btn1.text = "Elefante";
                                btn2.text = "Jirafa";
                                break;
                        }
                        break;
                    case 13:
                        preg.text = "¿De qué está cubierto el cuerpo del oso polar?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Pelaje";
                        elemid = 6660133;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Plumas";
                                btn3.text = "Escamas";
                                break;
                            case 1:
                                btn1.text = "Nada";
                                btn3.text = "Plumas";
                                break;
                            case 2:
                                btn1.text = "Escamas";
                                btn2.text = "Nada";
                                break;
                        }
                        break;
                    case 14:
                        preg.text = "¿De qué está cubierto el cuerpo del pingüino?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Plumas";
                        elemid = 6660134;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Pelaje";
                                btn3.text = "Escamas";
                                break;
                            case 1:
                                btn1.text = "Nada";
                                btn3.text = "Pelaje";
                                break;
                            case 2:
                                btn1.text = "Escamas";
                                btn2.text = "Nada";
                                break;
                        }
                        break;
                    case 15:
                        preg.text = "¿En qué hábitat las condiciones son extremas debido al calor?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Desierto";
                        elemid = 6660135;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Bosque";
                                btn3.text = "Playa";
                                break;
                            case 1:
                                btn1.text = "Playa";
                                btn3.text = "Polar";
                                break;
                            case 2:
                                btn1.text = "Polar";
                                btn2.text = "Jungla";
                                break;
                        }
                        break;
                    case 16:
                        preg.text = "¿En qué hábitat las condiciones son extremas debido al frío?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Polar";
                        elemid = 6660136;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Desierto";
                                btn3.text = "Playa";
                                break;
                            case 1:
                                btn1.text = "Jungla";
                                btn3.text = "Montaña";
                                break;
                            case 2:
                                btn1.text = "Montaña";
                                btn2.text = "Mar";
                                break;
                        }
                        break;
                    case 17:
                        preg.text = "¿En qué hábitat el clima es variado?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Bosque";
                        elemid = 6660137;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Desierto";
                                btn3.text = "Playa";
                                break;
                            case 1:
                                btn1.text = "Jungla";
                                btn3.text = "Desierto";
                                break;
                            case 2:
                                btn1.text = "Polar";
                                btn2.text = "Mar";
                                break;
                        }
                        break;
                    case 18:
                        preg.text = "¿En qué hábitat se encuentran dunas?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Desierto";
                        elemid = 6660138;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Polar";
                                btn3.text = "Jungla";
                                break;
                            case 1:
                                btn1.text = "Jungla";
                                btn3.text = "Montaña";
                                break;
                            case 2:
                                btn1.text = "Polar";
                                btn2.text = "Ciudad";
                                break;
                        }
                        break;
                    case 19:
                        preg.text = "¿En qué hábitat se encuentra la mayor cantidad de flora y fauna?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Bosque";
                        elemid = 6660139;
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Polar";
                                btn3.text = "Desierto";
                                break;
                            case 1:
                                btn1.text = "Desierto";
                                btn3.text = "Playa";
                                break;
                            case 2:
                                btn1.text = "Polar";
                                btn2.text = "Playa";
                                break;
                        }
                        break;

                }
            }

        }
    }
  

 //   void OnTriggerExit(Collider other)
 //   {
 //       if (other.gameObject.CompareTag("Player"))
 //       {
 //           GetCanvas.SetActive(false);
 //       }
 //   }

    public void clickity1()
    {

        if (resp == btns[0].text)
        {
            agregar_correcta();
            dataScene.contador = dataScene.contador + 1;
            if (basura.name == "0")
            {
                dataScene.estadob1 = false;
                Debug.Log(dataScene.estadob1);
            }else if (basura.name == "1")
            {
                dataScene.estadob2 = false;
            }
            else if (basura.name == "2")
            {
                dataScene.estadob3 = false;
            }
            else if (basura.name == "3")
            {
                dataScene.estadob4 = false;
            }
            else if (basura.name == "4")
            {
                dataScene.estadob5 = false;
            }
            else if (basura.name == "5")
            {
                dataScene.estadob6 = false;
            }
            else if (basura.name == "6")
            {
                dataScene.estadob7 = false;
            }
            else if (basura.name == "7")
            {
                dataScene.estadob8 = false;
            }
            else if (basura.name == "8")
            {
                dataScene.estadob9 = false;
            }
            else if (basura.name == "9")
            {
                dataScene.estadob10 = false;
            }
            basura.SetActive(false);

            //DataScene.estadob
        }
        else
        {
            resp2 = btns[0].text;
            agregar_incorrecta();
            GetCanvas.SetActive(false);

        }
        //aaa.salirActividad(60010);
        //Tiempo.SetActive(false);
        audioSource.Stop();
        GameObject.FindWithTag("Tiempo").SendMessage("Finnish");
    }

    public void clickity2()
    {

        if (resp == btns[01].text)
        {
            agregar_correcta();
            dataScene.contador = dataScene.contador + 1;
            if (basura.name == "0")
            {
                dataScene.estadob1 = false;
                Debug.Log(dataScene.estadob1);
            }
            else if (basura.name == "(1")
            {
                dataScene.estadob2 = false;
            }
            else if (basura.name == "2")
            {
                dataScene.estadob3 = false;
            }
            else if (basura.name == "3")
            {
                dataScene.estadob4 = false;
            }
            else if (basura.name == "4")
            {
                dataScene.estadob5 = false;
            }
            else if (basura.name == "5")
            {
                dataScene.estadob6 = false;
            }
            else if (basura.name == "6")
            {
                dataScene.estadob7 = false;
            }
            else if (basura.name == "7")
            {
                dataScene.estadob8 = false;
            }
            else if (basura.name == "8")
            {
                dataScene.estadob9 = false;
            }
            else if (basura.name == "9")
            {
                dataScene.estadob10 = false;
            }
            basura.SetActive(false);

            //DataScene.estadob
        }
        else
        {
            resp2 = btns[1].text;
            agregar_incorrecta();
            GetCanvas.SetActive(false);
            
        }
        audioSource.Stop();
        GameObject.FindWithTag("Tiempo").SendMessage("Finnish");

    }
    public void clickity3()
    {

        if (resp == btns[2].text)
        {
            agregar_correcta();
            dataScene.contador = dataScene.contador + 1;
            if (basura.name == "0")
            {
                dataScene.estadob1 = false;
            }
            else if (basura.name == "1")
            {
                dataScene.estadob2 = false;
            }
            else if (basura.name == "2")
            {
                dataScene.estadob3 = false;
            }
            else if (basura.name == "3")
            {
                dataScene.estadob4 = false;
            }
            else if (basura.name == "4")
            {
                dataScene.estadob5 = false;
            }
            else if (basura.name == "5")
            {
                dataScene.estadob6 = false;
            }
            else if (basura.name == "6")
            {
                dataScene.estadob7 = false;
            }
            else if (basura.name == "7")
            {
                dataScene.estadob8 = false;
            }
            else if (basura.name == "8")
            {
                dataScene.estadob9 = false;
            }
            else if (basura.name == "9")
            {
                dataScene.estadob10 = false;
            }
            basura.SetActive(false);
            
            //DataScene.estadob
        }
        else
        {
            resp2 = btns[2].text;
            agregar_incorrecta();
            GetCanvas.SetActive(false);
            
        }
        audioSource.Stop();
        GameObject.FindWithTag("Tiempo").SendMessage("Finnish");

    }

    public IEnumerator PostAdd(Respuestabasuras respueston)
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
        Respuestabasuras respuestini;
        respuestini = new Respuestabasuras();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60010;
        respuestini.id_elemento = elemid;
        DateTime ahora = DateTime.Now;
        respuestini.datetime_touch = ahora.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
        respuestini.Eje_X = gameObject.transform.position.x;
        respuestini.Eje_Y = gameObject.transform.position.y;
        respuestini.Eje_Z = gameObject.transform.position.z;
        respuestini.correcta = 1;
        respuestini.resultado = resp;
        respuestini.Tipo_Registro = "1";
        StartCoroutine(PostAdd(respuestini));
    }

    public void agregar_incorrecta()
    {
        Respuestabasuras respuestini;
        respuestini = new Respuestabasuras();
        respuestini.id_per = 202202;
        respuestini.id_user = Login.user_id;
        respuestini.id_reim = 666;
        respuestini.id_actividad = 60010;
        respuestini.id_elemento = elemid;
        DateTime ahora = DateTime.Now;
        respuestini.datetime_touch = ahora.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
        respuestini.Eje_X = gameObject.transform.position.x;
        respuestini.Eje_Y = gameObject.transform.position.y;
        respuestini.Eje_Z = gameObject.transform.position.z;
        respuestini.correcta = 0;
        respuestini.resultado = resp2;
        respuestini.Tipo_Registro = "0";
        StartCoroutine(PostAdd(respuestini));
    }



}
