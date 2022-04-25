using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class limpiarPHacha : MonoBehaviour
{


    public TextMeshProUGUI textError;
    [SerializeField]
    public int price;

    // Start is called before the first frame update
    void LateUpdate()
    {
        if (dataScene.estadop3 == false)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void limpiarCamino()
    { //ITEMOBSTACULO MALO CAMBIAR

        if (dataScene.estadoi3 == true)
        {
            if (dataScene.upoints >= price)
            {
                Debug.Log("1");
                dataScene.upoints = dataScene.upoints - price;
                dataScene.estadop3 = false;
                gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("2");
                textError.text = "¡Insuficientes uLearnet points!";
            }
        }
        else
        {
            textError.text = "¡Objeto no encontrado!";
        }

    }
}
