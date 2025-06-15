using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Shop_Buttons : MonoBehaviour{

    public GameObject Receipt;
    public Animator ReceicptAnimator;

    public void OnExitButtonClick()
    {
        SceneManager.LoadScene("Holiday_Planet");
    }

    public void OnReceiptClick()
    {
        if (ReceicptAnimator != null)
        {
            StartCoroutine(DelayedThing());
            Receipt.SetActive(true);
            ReceicptAnimator.SetBool("Is Purchasing ??",true);
            IEnumerator DelayedThing()
            {
                yield return new WaitForSeconds(1.1f);
                
            }
        }
    }

    public void OnReceiptConfirmClick()
    {

    }

    public void OnReceiptCancelClick()
    {
        if (ReceicptAnimator != null)
        {
            StartCoroutine(DelayedThing());
            ReceicptAnimator.SetBool("Is Purchasing ??", false);
            IEnumerator DelayedThing()
            {
                yield return new WaitForSeconds(1.5f);
                Receipt.SetActive(false);
            }
        }
    }
}
