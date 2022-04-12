using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class limpiarPagua : MonoBehaviour
{
    public TextMeshProUGUI textError;
    [SerializeField]
    public int price;

    // Start is called before the first frame update
    void LateUpdate()
    {
        if (dataScene.estadop2 == false)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void limpiarCamino()
    { //ITEMOBSTACULO MALO CAMBIAR
        Debug.Log(dataScene.estadoi2);
        Debug.Log(dataScene.upoints);
        Debug.Log(price);
        if (dataScene.estadoi2 == true)
        {
            if (dataScene.upoints >= price)
            {
                Debug.Log("1");
                dataScene.estadop2 = false;
                gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("2");
                textError.text = "¡Insuficientes uLearnet points!";
                dataScene.estadoi2 = false;
            }
        }
        else
        {
            textError.text = "¡Objeto no encontrado!";
            dataScene.estadoi2 = false;
        }

    }
}
