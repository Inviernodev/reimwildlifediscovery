using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class scriptPalabrasDibujo : MonoBehaviour
{
    int x;
    [SerializeField]
    public TMP_Text _title;
    [SerializeField]
    string[] names = new string[17];
    [SerializeField]
    int[] numbers = new int[17];

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0, 18);

        _title.text = names[x];
        guardardibujo.elemid = numbers[x];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
