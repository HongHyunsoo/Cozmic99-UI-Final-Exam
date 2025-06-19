using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Daily_Adjustment : MonoBehaviour
{
    public void OnCloseClick()
    {
        SceneManager.LoadScene("Kitchen");
    }
}
