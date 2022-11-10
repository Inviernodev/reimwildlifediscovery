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
                GameObject.FindWithTag("uiobjetos").SendMessage("item1");
            }
            else if (gameObject.name == "Agua(Clone)")
            {
                dataScene.estadoi2 = true;
                GameObject.FindWithTag("uiobjetos").SendMessage("item2");
            }
            else if (gameObject.name == "Hacha(Clone)")
            {
                dataScene.estadoi3 = true;
                GameObject.FindWithTag("uiobjetos").SendMessage("item3");
            }
            gameObject.SetActive(false);
        }
    }
}
