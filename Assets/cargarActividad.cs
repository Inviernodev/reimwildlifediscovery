using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cargarActividad : MonoBehaviour
{
    public string nombrescene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nombrescene);
        }

    }

    public void clickBtnexit()
    {
        SceneManager.LoadScene(nombrescene);
        TiempoxActividad.swit = 1;
    }

}
