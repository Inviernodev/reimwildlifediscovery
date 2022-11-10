using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlat : MonoBehaviour
{
    //You can drag a game object from your scene into this field in the inspector
    public GameObject myObject;
    public GameObject moverplat;
    public Plataformas plat;
    private Vector3 savedPosition;
    public GameObject letrero;

    void Start()
    {
        savedPosition = myObject.transform.position;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.SetActive(false);
            plat.caido = true;
            moverplat.SetActive(false);

            collision.gameObject.transform.position = savedPosition;
            collision.gameObject.SetActive(true);
        }
    }

}
