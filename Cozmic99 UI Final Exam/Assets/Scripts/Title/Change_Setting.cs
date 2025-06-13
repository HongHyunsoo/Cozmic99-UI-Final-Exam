using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Change_Setting : MonoBehaviour
{
    public GameObject Setting_Graphic;
    public GameObject Setting_Audio;
    public GameObject Setting_Key;
    public GameObject Setting_User;

    public void OnGraphicButtonClick()
    {
        Setting_Graphic.SetActive(true);
        Setting_Audio.SetActive(false);
        Setting_Key.SetActive(false);
        Setting_User.SetActive(false);
    }

    public void OnAudioButtonClick()
    {
        Setting_Graphic.SetActive(false);
        Setting_Audio.SetActive(true);
        Setting_Key.SetActive(false);
        Setting_User.SetActive(false);
    }
    public void OnKeyButtonClick()
    {
        Setting_Graphic.SetActive(false);
        Setting_Audio.SetActive(false);
        Setting_Key.SetActive(true);
        Setting_User.SetActive(false);
    }

    public void OnUserButtonClick()
    {
        Setting_Graphic.SetActive(false);
        Setting_Audio.SetActive(false);
        Setting_Key.SetActive(false);
        Setting_User.SetActive(true);
    }

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Kitchen");
    }
}
