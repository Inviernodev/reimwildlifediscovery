using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class triggerLimpiarBasura : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI btn1;
    public TextMeshProUGUI btn2;
    public TextMeshProUGUI btn3;
    public TextMeshProUGUI preg;
    public TextMeshProUGUI[] btns = new TextMeshProUGUI[3];
    public string resp;
    public GameObject basura;
    public GameObject GetCanvas;
    public GameObject GetCanvas3;
    [SerializeField] TextMeshProUGUI GetCanvas2;
    int z;
    int x;
    int basuranumero;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && dataScene.upoints >= 500)
        {
            GetCanvas.SetActive(true);
            dataScene.upoints = dataScene.upoints - 500;
            GetCanvas2.text = "-500";
            GetCanvas3.SetActive(true);
            x = Random.Range(0, 3); // 0,30

            switch (x)
            {
                case 0:
                    preg.text = "¿Cual animal es el mas grande entre estos?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Elefante";
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
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;
                case 2:
                    preg.text = "¿En que hábitat se encuentran gorilas?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Jungla";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;
                case 3:
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;

                case 4:
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;

                case 5:
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;
                case 6:
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;
                case 7:
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;
                case 8:
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "Desierto";
                            btn3.text = "Bosque";
                            break;
                        case 1:
                            btn1.text = "Montaña";
                            btn3.text = "Sabana";
                            break;
                        case 2:
                            btn1.text = "Sabana";
                            btn2.text = "Bosque";
                            break;
                    }
                    break;
            }
        }
    }
  

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetCanvas.SetActive(false);
        }
    }

    public void clickity1()
    {

        if (resp == btns[0].text)
        {
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
            GetCanvas.SetActive(false);
        }
    }

    public void clickity2()
    {

        if (resp == btns[01].text)
        {
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
            GetCanvas.SetActive(false);
        }
    }
    public void clickity3()
    {

        if (resp == btns[2].text)
        {
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
            GetCanvas.SetActive(false);
        }
    }
}
