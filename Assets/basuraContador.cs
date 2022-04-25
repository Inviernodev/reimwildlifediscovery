using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class basuraContador : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI textoPoints;

    // Update is called once per frame
    void Update()
    {
        textoPoints.text = dataScene.contador.ToString() + " / 10";
    }
}
