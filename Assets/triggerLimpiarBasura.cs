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
    public GameObject Tiempo;
    public TiempoxActividad aaa;
    int z;
    int x;
    int basuranumero;

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

                switch (x)
                {
                    case 0:
                        preg.text = "¿Cuál animal es el más grande entre estos?";
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
                        preg.text = "¿En qué hábitat existen glaciares?";
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
                        preg.text = "¿Cuál animal contiene escamas?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Cocodrilo";
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
                        preg.text = "¿Cuál animal contiene escamas?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Serpiente";
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
                                btn2.text = "Mar";
                                break;
                        }
                        break;
                    case 19:
                        preg.text = "¿En qué hábitat se encuentra la mayor cantidad de flora y fauna?";
                        z = Random.Range(0, 3);
                        btns[z].text = "Bosque";
                        resp = btns[z].text;
                        switch (z)
                        {
                            case 0:
                                btn2.text = "Polar";
                                btn3.text = "Jungla";
                                break;
                            case 1:
                                btn1.text = "Jungla";
                                btn3.text = "Playa";
                                break;
                            case 2:
                                btn1.text = "Polar";
                                btn2.text = "Mar";
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
        //aaa.salirActividad(60010);
        //Tiempo.SetActive(false);
        GameObject.FindWithTag("Tiempo").SendMessage("Finnish");
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
        GameObject.FindWithTag("Tiempo").SendMessage("Finnish");

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
        GameObject.FindWithTag("Tiempo").SendMessage("Finnish");

    }
}
