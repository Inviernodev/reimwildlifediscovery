using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkinPanel : MonoBehaviour
{
    public int nskin;
    public GameObject skindefault;
    public GameObject[] skins = new GameObject[10];
    public GameObject[] skinpic = new GameObject[10];
    public GameObject GetCanvas;
    public TextMeshProUGUI precio;
    public GameObject target;


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
            if(dataScene.upoints >= int.Parse(precio.text))
            {
                skindefault.SetActive(false);
                GetCanvas.SetActive(false);
                dataScene.upoints = dataScene.upoints - int.Parse(precio.text);
                skins[nskin].SetActive(true);
                dataScene.skin = nskin;
            }
            else
            {
                precio.text = "¡Insuficientes uPoints!";
            }

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
        switch (nskin)
        {
            case 0:
                precio.text = "0";
                break;
            case 1:
                precio.text = "0";
                break;
            case 2:
                precio.text = "1500";
                break;
            case 3:
                precio.text = "1500";
                break;
            case 4:
                precio.text = "2000";
                break;
            case 5:
                precio.text = "2000";
                break;
            case 6:
                precio.text = "2500";
                break;
            case 7:
                precio.text = "2500";
                break;
            case 8:
                precio.text = "3000";
                break;
            case 9:
                precio.text = "3000";
                break;
        }
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

        switch (nskin)
        {
            case 0:
                precio.text = "0";
                break;
            case 1:
                precio.text = "0";
                break;
            case 2:
                precio.text = "1500";
                break;
            case 3:
                precio.text = "1500";
                break;
            case 4:
                precio.text = "2000";
                break;
            case 5:
                precio.text = "2000";
                break;
            case 6:
                precio.text = "2500";
                break;
            case 7:
                precio.text = "2500";
                break;
            case 8:
                precio.text = "3000";
                break;
            case 9:
                precio.text = "3000";
                break;
        }
    }

    public void closeCanvas()
    {
        GetCanvas.SetActive(false);
    }
}
