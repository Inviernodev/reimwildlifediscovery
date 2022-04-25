using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactCollision : MonoBehaviour
{
    public GameObject obj1;
    void React()
    {
        Debug.Log("Reacciono");
        obj1.transform.position = new Vector3(-81, -22.18f, -130.31f);
    }
}
