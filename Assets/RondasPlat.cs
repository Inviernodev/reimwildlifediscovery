using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class RondasPlat : MonoBehaviour
{
    public Plataformas plat;
    public GameObject textotimer;
    public GameObject textotimer2;
    public GameObject platprinci;
    [SerializeField] TextMeshProUGUI m_Object;
    public float targetTime = 6.0f;

    public void Update()
    {

        targetTime -= Time.deltaTime;
        m_Object.text = targetTime.ToString("f0");

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        plat.defaultplat();
        targetTime = 6.0f;
        textotimer.SetActive(false);
        plat.saveObj.SetActive(false);
        platprinci.SetActive(false);
        textotimer2.SetActive(true);

    }


}
//{
//    public Plataformas plat;
//    public float targettime = 10.0f;
//    [SerializeField] TextMeshProUGUI m_Object;
//    public GameObject textotimer;
//    //public GameObject textotimer2;

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        targettime -= Time.deltaTime;
//        m_Object.text = targettime.ToString();
//        if (targettime <= 0.0f)
//        {

//            timerended();
//        }

//    }

//    void timerended()
//    {
//        //plat.saveObj.SetActive(false);

//        /plat.defaultplat();
//        //textotimer2.SetActive(true);     //15segundos tiemr
//        targettime = 5.0f;
//        textotimer.SetActive(false);

//    }
//}

