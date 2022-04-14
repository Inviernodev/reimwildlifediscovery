using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCanvasActividad : MonoBehaviour
{
    [SerializeField]
    public GameObject GetCanvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetCanvas.SetActive(true);
        }
    }
}
