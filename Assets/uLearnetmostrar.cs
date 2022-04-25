using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uLearnetmostrar : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI textoPoints;

    // Update is called once per frame
    void Update()
    {
        textoPoints.text = dataScene.upoints.ToString();
    }
}
