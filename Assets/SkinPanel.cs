using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinPanel : MonoBehaviour
{
    public int nskin;
    public GameObject skindefault;
    public GameObject[] skins = new GameObject[10];
    public GameObject[] skinpic = new GameObject[10];
    public GameObject GetCanvas;


    // Start is called before the first frame update
    public void Start()
    {
        nskin = 0;
        skinpic[nskin].SetActive(true);
    }

    public void UseSkin()
    {
        skindefault = GameObject.FindWithTag("Player");
        if (skindefault.name == skins[nskin].name)
        {
            GetCanvas.SetActive(false);
        }
        else
        {
            skindefault.SetActive(false);
            GetCanvas.SetActive(false);
            skins[nskin].SetActive(true);
            
            dataScene.skin = nskin;
         }
    }

    public void cl1929ickLeft()
    {
        skinpic[nskin].SetActive(false);
        nskin = nskin - 1;
        if (nskin < 0)
        {
            nskin = skinpic.Length -1 ;
        }
        skinpic[nskin].SetActive(true);
    }

    public void clikkk()
    {
        skinpic[nskin].SetActive(false);
        nskin = nskin + 1;
        if(nskin == skinpic.Length)
        {
            nskin = 0;
        }
        skinpic[nskin].SetActive(true);
    }

    public void closeCanvas()
    {
        GetCanvas.SetActive(false);
    }
}
