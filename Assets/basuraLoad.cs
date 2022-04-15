using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basuraLoad : MonoBehaviour
{
    public GameObject[] Basuras = new GameObject[10];

    void LateUpdate()
    {
        if(dataScene.estadob1 == false)
        {
            Basuras[0].SetActive(false);
        }else if (dataScene.estadob2 == false)
        {
            Basuras[1].SetActive(false);
        }else if (dataScene.estadob3 == false)
        {
            Basuras[2].SetActive(false);
        }
        else if (dataScene.estadob4 == false)
        {
            Basuras[3].SetActive(false);
        }else if (dataScene.estadob5 == false)
        {
            Basuras[4].SetActive(false);
        }
        else if (dataScene.estadob6 == false)
        {
            Basuras[5].SetActive(false);
        }
        else if (dataScene.estadob7 == false)
        {
            Basuras[6].SetActive(false);
        }
        else if (dataScene.estadob8 == false)
        {
            Basuras[7].SetActive(false);
        }
        else if (dataScene.estadob9 == false)
        {
            Basuras[8].SetActive(false);
        }
        else if (dataScene.estadob10 == false)
        {
            Basuras[9].SetActive(false);
        }
    }
}
