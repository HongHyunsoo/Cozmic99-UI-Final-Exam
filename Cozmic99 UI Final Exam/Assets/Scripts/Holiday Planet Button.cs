using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HolidayPlanetButton : MonoBehaviour
{
    public GameObject DialogObject;

    public void OnNPCClick()
    {
        DialogObject.SetActive(true);
    }

    public void OnShopClick()
    {
        SceneManager.LoadScene("Shop");
    }

    public void OnSpaceShipClick()
    {
        SceneManager.LoadScene("Bedroom");
    }
    public void OnDialogExitClick()
    {
        DialogObject.SetActive(false);
    }
}
