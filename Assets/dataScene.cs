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
    public static bool estadob1;
    public static bool estadob2;
    public static bool estadob3;
    public static bool estadob4;
    public static bool estadob5;
    public static bool estadob6;
    public static bool estadob7;
    public static bool estadob8;
    public static bool estadob9;
    public static bool estadob10;
    public static int contador;

    // Any data you want this script to have


    // initialize the Singleton instance
    private void Start()
    {
        Debug.Log(Login.user_id);
        Screen.SetResolution(800, 480, true);
        //Estados puentes
        estadop1 = true;
        estadop2 = true;
        estadop3 = true;
        estadoi1 = false;
        estadoi2 = false;
        estadoi3 = false;
        skin = 0;
        contador = 0;
        upoints = 22220;
        estadob1 = true;
        estadob2 = true;
        estadob3 = true;
        estadob4 = true;
        estadob5 = true;
        estadob6 = true;
        estadob7 = true;
        estadob8 = true;
        estadob9 = true;
        estadob10 = true;

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