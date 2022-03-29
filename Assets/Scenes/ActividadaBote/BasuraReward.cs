using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraReward : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Basura")
        {
            ScoreCounter.scoreValue += 10;
            ScoreCounter.basuraValue += 1;
            Destroy(other.gameObject);
        }
    }
}
