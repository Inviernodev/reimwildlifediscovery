using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text basuraText;
    [SerializeField]
    public GameObject basura1;
    public GameObject basura2;
    public GameObject basura3;


    public static int scoreValue;
    public static int basuraValue;
    public static int basuraTotal;

    void Start()
    {
        basuraTotal = GameObject.FindGameObjectsWithTag("Basura").Length;
    }

    void Update()
    {
        switch (basuraValue)
        {
            case 1:
                basura1.SetActive(true);
                break;
            case 2:
                basura2.SetActive(true);
                break; 
            case 3:
                basura3.SetActive(true);
                break;

        }
        scoreText.text = "uLearnet Points: " + scoreValue;
        basuraText.text = "Basura recogida: " +  basuraValue + "/" + basuraTotal;
    }
}
