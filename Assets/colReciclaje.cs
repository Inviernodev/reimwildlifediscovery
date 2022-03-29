using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colReciclaje : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Basura")
        {
            ScoreCounter.scoreValue += 10;
            ScoreCounter.basuraValue += 1;
            Destroy(other.gameObject);
        }
    }
}
