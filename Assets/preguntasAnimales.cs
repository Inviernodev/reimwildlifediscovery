using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preguntasAnimales : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        int preg = Random.Range(1, 4);
        TextMesh textObject = GameObject.Find("textOso").GetComponent<TextMesh>();
        TextMesh textResp1 = GameObject.Find("respOso1").GetComponent<TextMesh>();
        TextMesh textResp2 = GameObject.Find("respOso2").GetComponent<TextMesh>();
        TextMesh textResp3 = GameObject.Find("respOso3").GetComponent<TextMesh>();

        switch (preg){

            case 1:
                textObject.text = "¿De que tamaño soy?";
                textResp1.text = "Grande";
                textResp2.text = "Pequeño";
                textResp3.text = "Mediano";
                break;
            case 2:
                textObject.text = "¿Como es mi pelaje?";
                textResp1.text = "Corto";
                textResp2.text = "Largo";
                textResp3.text = "Mediano";
                break;
            case 3:
                textObject.text = "¿De que color soy?";
                textResp1.text = "Cafe";
                textResp2.text = "Naranjo";
                textResp3.text = "Negro";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
