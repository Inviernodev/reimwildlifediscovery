using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class limpiarPuente : MonoBehaviour
{
 
  
    public TextMeshProUGUI textError;
    [SerializeField]
    public int price;

    // Start is called before the first frame update
    void LateUpdate()
    {
        if (dataScene.estadop1 == false)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void limpiarCamino()
    { //ITEMOBSTACULO MALO CAMBIAR
        Debug.Log(dataScene.estadoi1);
        Debug.Log(dataScene.upoints);
        Debug.Log(price);
        if (dataScene.estadoi1 == true)
        {
            if (dataScene.upoints >= price)
            {
                Debug.Log("1");
                dataScene.estadop1 = false;
                gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("2");
                textError.text = "ĦInsuficientes uLearnet points!";
            }
        }
        else
        {
            textError.text = "ĦObjeto no encontrado!";
        }
        
    }
}
