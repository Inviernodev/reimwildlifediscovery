using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerObjeto : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == "Pala(Clone)")
            {
                dataScene.estadoi1 = true;
            }
            else if (gameObject.name == "Agua(Clone)")
            {
                dataScene.estadoi2 = true;
            }
            else if (gameObject.name == "Hacha(Clone)")
            {
                dataScene.estadoi3 = true;
            }
            gameObject.SetActive(false);
        }
    }
}
