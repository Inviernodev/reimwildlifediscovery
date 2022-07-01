using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cambiopuntos : MonoBehaviour
{
    public float targetTime = 5.0f;

    public void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        this.gameObject.SetActive(false);
        targetTime = 5.0f;
    }
}
