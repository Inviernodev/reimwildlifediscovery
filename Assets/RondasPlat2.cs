using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RondasPlat2 : MonoBehaviour
{
    public Plataformas plat;
    public float targettime = 15.0f;
    [SerializeField] TextMeshProUGUI m_Object;
    public GameObject textotimer;
    public GameObject textotimer2;

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
        plat.backuplat();
        plat.mostrarplat();
        targettime = 5.0f;
        plat.caidaplat();
        textotimer2.SetActive(true);
    }
}
