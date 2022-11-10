using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiobjetos : MonoBehaviour
{
    public GameObject img1;
    public GameObject img1gray;
    public GameObject img2;
    public GameObject img2gray;
    public GameObject img3;
    public GameObject img3gray;
    // Start is called before the first frame update
    void Start()
    {
        if (dataScene.estadoi1)
        {
            img1.SetActive(true);
        }
        else
        {
            img1gray.SetActive(true);
        }

        if (dataScene.estadoi2)
        {
            img2.SetActive(true);
        }
        else
        {
            img2gray.SetActive(true);
        }

        if (dataScene.estadoi3)
        {
            img3.SetActive(true);
        }
        else
        {
            img3gray.SetActive(true);
        }
    }

    // Update is called once per frame
    public void item1()
    {
        img1.SetActive(true);
        img1gray.SetActive(false);
    }

    public void item2()
    {
        img2.SetActive(true);
        img2gray.SetActive(false);
    }

    public void item3()
    {
        img3.SetActive(true);
        img3gray.SetActive(false);
    }
}
