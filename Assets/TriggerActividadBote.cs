using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerActividadBote : MonoBehaviour
{
    public string nombrescene;

    public void clickBtncomenzar()
    {
        SceneManager.LoadScene(nombrescene);
    }

    public void clickBtnsalir()
    {
        this.gameObject.SetActive(false);
    }
}
