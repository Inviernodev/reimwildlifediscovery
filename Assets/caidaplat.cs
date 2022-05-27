using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caidaplat : MonoBehaviour
{
    //You can drag a game object from your scene into this field in the inspector
    public GameObject myObject;
    //public Plataformas plat;

    private Vector3 savedPosition;

    void Start()
    {
        savedPosition = myObject.transform.position;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = savedPosition;
            collision.gameObject.SetActive(true);
            //plat.nxtronda = false;
        }
    }
}
