using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinLoad : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] skins = new GameObject[10];
    public GameObject GetCanvas;

    private void OnTriggerEnter(Collider other)
    {
        //SkinPanel.ctd = false;
        if (other.gameObject.CompareTag("Player"))
        {
            
            GetCanvas.SetActive(true);

            

            Debug.Log("TOUCH");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        //SkinPanel.ctd = false;
        if (other.gameObject.CompareTag("Player"))
        {

            GetCanvas.SetActive(false);



            Debug.Log("TOUCH");
        }

    }

    public void Start()
    {
        skins[0].SetActive(false);
        skins[dataScene.skin].SetActive(true);
        
    }
}
