using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kitchen : MonoBehaviour
{
    public void OnCloseClick()
    {
        SceneManager.LoadScene("Bedroom");
    }
}
