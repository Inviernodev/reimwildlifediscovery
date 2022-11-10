using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    public void MuteToggle()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

}
