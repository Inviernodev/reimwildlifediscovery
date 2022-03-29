using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    public Camera nuevaCamara;
    public Camera camara;
    public GameObject GetCanvas;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            GameObject.Find("Player").SendMessage("Finnish");
            nuevaCamara.gameObject.SetActive(true);
            camara.gameObject.SetActive(false);
            GetCanvas.SetActive(true);
        }

    }

}
