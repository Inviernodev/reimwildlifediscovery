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
    public TextMeshProUGUI resp;
    public GameObject basura;
    public GameObject GetCanvas;
    int z;
    int x;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetCanvas.SetActive(true);
            x = Random.Range(0, 2);
            switch (x)
            {
                case 0:
                    preg.text = "¿Alternativa b correcta?";
                    z = Random.Range(0, 3);
                    btns[z].text = "B";
                    resp.text = btns[z].text;
                    switch (z)
                    {
                        case 0:
                            btn2.text = "A";
                            btn3.text = "C";
                            break;
                        case 1:
                            btn1.text = "C";
                            btn3.text = "A";
                            break;
                        case 2:
                            btn1.text = "A";
                            btn2.text = "C";
                            break;
                    }
                    break;
                case 1:
                    preg.text = "¿En que hábitat existen glaciares?";
                    z = Random.Range(0, 3);
                    btns[z].text = "Polar";
                    resp.text = btns[z].text;
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

                    break;
                case 3:

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

        if (resp.text == btns[0].text)
        {
            Debug.Log("11111111");
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

        if (resp.text == btns[1].text)
        {
            Debug.Log("2222222222");
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

        if (resp.text == btns[2].text)
        {
            Debug.Log("33333333");
            basura.SetActive(false);
            //DataScene.estadob
        }
        else
        {
            GetCanvas.SetActive(false);
        }
    }
}
