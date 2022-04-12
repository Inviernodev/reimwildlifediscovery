using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformasMove : MonoBehaviour
{
    float x;
    float y;
    float z;
    [SerializeField]
    float z2;
    [SerializeField]
    float z3;

    private GameObject target = null;
    private Vector3 offset;

    void FixedUpdate()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        Vector3 pointA = new Vector3(x, y, z+z2);
        Vector3 pointB = new Vector3(x, y, z-z3);
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }

    void Start()
    {
        target = null;
    }
    void OnTriggerEnter(Collider col)
    {
        target = col.gameObject;
        target.transform.SetParent(gameObject.transform, true);
    }
    void OnTriggerExit(Collider col)
    {
        target.transform.SetParent(GameObject.Find("Player").transform, true);
        //target.transform.parent = null;
        target = null;
    }

}
