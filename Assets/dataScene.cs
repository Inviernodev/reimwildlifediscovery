using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataScene : MonoBehaviour
{
    public static dataScene Instance;
    public static bool estadop1;
    public static bool estadop2;
    public static bool estadop3;
    public static bool estadoi1;
    public static bool estadoi2;
    public static bool estadoi3;
    public static int skin;
    public static int upoints;

    // Any data you want this script to have


    // initialize the Singleton instance
    private void Start()
    {
        //Estados puentes
        estadop1 = true;
        estadop2 = true;
        estadop3 = true;
        estadoi1 = false;
        estadoi2 = false;
        estadoi3 = false;
        skin = 0;
        upoints = 0;
        Debug.Log(estadop1);
        Debug.Log(estadop2);
        Debug.Log(estadop3);
        Debug.Log(estadoi1);
        Debug.Log(estadoi2);
        Debug.Log(estadoi3);
        Debug.Log(skin);
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null)
        {
            Instance = this;

            // Carry over from one scene to the next
           //ontDestroyOnLoad(Instance.gameObject);
        }
        else
        {
            DestroyObject(gameObject);
        }
    }


}