using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rondasplat3 : MonoBehaviour
{
    public Plataformas plat;
    public float targettime = 3.0f;
    [SerializeField] TextMeshProUGUI m_Object;
    public GameObject textotimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targettime -= Time.deltaTime;
        m_Object.text = targettime.ToString("f0");
        if (targettime <= 0.0f)
        {
            timerended();
        }

    }

    void timerended()
    {
        textotimer.SetActive(false);
        targettime = 3.0f;
        if (plat.caido==false)
        {
            plat.iniciarronda();
        }
        else
        {
            //dar recompensas por rondas
            plat.btn.SetActive(true);
            Debug.Log("Ya fue la dota");
        }
        
    }
}
