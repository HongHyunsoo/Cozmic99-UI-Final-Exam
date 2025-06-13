using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonHandler : MonoBehaviour
{
    public Animator doorAnimator;
    public Animator ScreenAnimator;
    public GameObject TItleTexts;

    public GameObject Screen;
    public GameObject Screen_Setting;
    public GameObject Screen_Credit;
    public GameObject Screen_Save;

    
    public void OnStartButtonClicked()
    {
        if (doorAnimator != null && ScreenAnimator != null)
        {
            StartCoroutine(DelayedThing());
            doorAnimator.SetBool("Is Open?", true); //  Bool true로 설정
            TItleTexts.SetActive(false);  // 여기서 꺼짐
            ScreenAnimator.SetBool("Is ScreenOpen?", true); //  Bool true로 설정
            
            IEnumerator DelayedThing()
            {
                yield return new WaitForSeconds(1.2f);
                Screen.SetActive(true);
                Screen_Save.SetActive(true);
            }

            
        }
    }

    public void OnSettingButtonClicked()
    {
        if (doorAnimator != null && ScreenAnimator != null)
        {
            StartCoroutine(DelayedThing());
            doorAnimator.SetBool("Is Open?", true); //  Bool true로 설정
            TItleTexts.SetActive(false);  // 여기서 꺼짐
            ScreenAnimator.SetBool("Is ScreenOpen?", true); //  Bool true로 설정

            IEnumerator DelayedThing()
            {
                yield return new WaitForSeconds(1.2f);
                Screen.SetActive(true);
                Screen_Setting.SetActive(true);
            }


        }
    }

    public void OnCreditButtonClicked()
    {
        if (doorAnimator != null && ScreenAnimator != null)
        {
            StartCoroutine(DelayedThing());
            doorAnimator.SetBool("Is Open?", true); //  Bool true로 설정
            TItleTexts.SetActive(false);  // 여기서 꺼짐
            ScreenAnimator.SetBool("Is ScreenOpen?", true); //  Bool true로 설정

            IEnumerator DelayedThing()
            {
                yield return new WaitForSeconds(1.2f);
                Screen.SetActive(true);
                Screen_Credit.SetActive(true);
            }


        }
    }

    public void OnExitButtenClicked()
    {
        if (doorAnimator != null && ScreenAnimator != null)
        {
            StartCoroutine(DelayedThing());

            doorAnimator.SetBool("Is Open?", false); //  Bool false로 설정
            ScreenAnimator.SetBool("Is ScreenOpen?", false); //  Bool false로 설정

            Screen_Setting.SetActive(false);
            Screen_Credit.SetActive(false);
            Screen_Save.SetActive(false);

            IEnumerator DelayedThing()
            {
                yield return new WaitForSeconds(0.8f);
                Screen.SetActive(true);
                TItleTexts.SetActive(true);  // 타이틀 버튼 글씨 여기서 켜짐
            }
            
            
            
        }
    }
}