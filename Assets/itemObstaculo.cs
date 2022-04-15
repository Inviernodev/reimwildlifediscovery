using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemObstaculo : MonoBehaviour
{
    public GameObject[] spawns = new GameObject[4];
    public GameObject[] items = new GameObject[3];
    [SerializeField] Transform[] Spawners;
    bool fin;

    void Start()
    {
        if (dataScene.estadop3)
        {
            fin = true;

            while (fin)
            {
                int x = Random.Range(0, 2);
                if (spawns[x].activeSelf)
                {
                    //spawn hacha
                    Instantiate(items[2], Spawners[x].position, Spawners[x].rotation);
                    spawns[x].SetActive(false);
                    fin = false;
                }
            }


        }


        if (dataScene.estadop2)
        {
            fin = true;

            while (fin)
            {
                int x = Random.Range(0, 3);
                if (spawns[x].activeSelf)
                {
                    //spawn agua
                    Instantiate(items[1], Spawners[x].position, Spawners[x].rotation);
                    spawns[x].SetActive(false);
                    fin = false;
                }
            }


        }

        if (dataScene.estadop1)
        {

            fin = true;

            while (fin)
            {
                int x = Random.Range(0, 4);
                if (spawns[x].activeSelf)
                {
                    //spawn Pala
                    Instantiate(items[0], Spawners[x].position, Spawners[x].rotation);
                    spawns[x].SetActive(false);
                    fin = false;
                }
            }
            
            
        }


        
    }

}
