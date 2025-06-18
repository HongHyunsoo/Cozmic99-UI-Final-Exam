using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bedroom : MonoBehaviour
{
    public void OnComputerClick()
    {
        SceneManager.LoadScene("Computer");
    }

    public void OnOutsideClick()
    {
        SceneManager.LoadScene("Holiday_Planet");
    }

    public void OnBedClick()
    {
        SceneManager.LoadScene("Daily_Adjustment");
    }
}
