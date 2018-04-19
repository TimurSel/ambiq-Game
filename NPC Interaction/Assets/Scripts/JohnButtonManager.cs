using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JohnButtonManager : MonoBehaviour
{
    public GameObject question1, question2, question3;
    public GameObject johnDialogue, johnDialoguePrefab, tomDialogue, robDialogue;
    public GameObject cross;

    public bool johnOn;

    #region Question #1
    public void HoiButton()
    {
        question1.SetActive(false);
        question2.SetActive(true);
        question2.transform.GetChild(2).gameObject.SetActive(true);
        question2.transform.GetChild(3).gameObject.SetActive(false);

    }
    public void WatwiljeButton()
    {
        question1.SetActive(false);
        question2.SetActive(true);
        question2.transform.GetChild(2).gameObject.SetActive(false);
        question2.transform.GetChild(3).gameObject.SetActive(true);
    }
    #endregion Question #1


    #region Question #2
    public void HetgaatgoedButton()
    {
        question2.SetActive(false);
        question3.SetActive(true);
        question3.transform.GetChild(2).gameObject.SetActive(true);
        question3.transform.GetChild(3).gameObject.SetActive(false);
    }
    public void WatgaatjouwdataanButton()
    {
        question2.SetActive(false);
        question3.SetActive(true);
        question3.transform.GetChild(2).gameObject.SetActive(false);
        question3.transform.GetChild(3).gameObject.SetActive(true);
    }
    #endregion Question #2


    #region Question #3
    public void OkeButton()
    {
        question3.SetActive(false);
        question1.SetActive(true);
        johnDialogue.SetActive(false);
        cross.SetActive(true);
        johnOn = false;
        Destroy(johnDialogue);
    }
    public void NiksButton()
    {
        question3.SetActive(false);
        question1.SetActive(true);
        johnDialogue.SetActive(false);
        cross.SetActive(true);
        johnOn = false;
        Destroy(johnDialogue);
    }
    #endregion Question #3

}