using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : JohnButtonManager
{

    public void OnDialogueStart(GameObject npc)
    {
        if(npc.name == "John" && !johnOn)
        {
            John(npc.name);
        }
        if(npc.name == "Tom")
        {
            Tom(npc.name);
        }
        if (npc.name == "Rob")
        {
            Rob(npc.name);
        }

    }

    public void John(string name)
    {
        cross.SetActive(false);
        johnOn = true;
        johnDialogue = Instantiate(johnDialoguePrefab, johnDialoguePrefab.transform);
        johnDialogue.transform.SetParent(GameObject.Find("Canvas").transform);
        johnDialogue.name = "JohnDialogue";
        johnDialogue.SetActive(true);
        FindJohnDialogue();
    }
    public void Tom(string name)
    {
        Debug.Log(name);
    }
    public void Rob(string name)
    {
        Debug.Log(name);
    }

    public void FindJohnDialogue()
    {
        johnDialogue.transform.position = GameObject.Find("Canvas").transform.position;

        question1 = johnDialogue.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject;
        question2 = johnDialogue.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject;
        question3 = johnDialogue.transform.GetChild(1).gameObject.transform.GetChild(3).gameObject;

        question1.SetActive(true);
        question2.SetActive(false);
        question3.SetActive(false);

        Button hoi = question1.transform.GetChild(1).transform.GetComponent<Button>();
        hoi.onClick.AddListener(GameObject.Find("Player").GetComponent<RaycastNPC>().HoiButton);
        Button watWilJe = question1.transform.GetChild(2).transform.GetComponent<Button>();
        watWilJe.onClick.AddListener(GameObject.Find("Player").GetComponent<RaycastNPC>().WatwiljeButton);

        Button hoeGaatHet = question2.transform.GetChild(0).transform.GetComponent<Button>();
        hoeGaatHet.onClick.AddListener(GameObject.Find("Player").GetComponent<RaycastNPC>().HetgaatgoedButton);
        Button watGaatDat = question2.transform.GetChild(1).transform.GetComponent<Button>();
        watGaatDat.onClick.AddListener(GameObject.Find("Player").GetComponent<RaycastNPC>().WatgaatjouwdataanButton);

        Button oke = question3.transform.GetChild(0).transform.GetComponent<Button>();
        oke.onClick.AddListener(GameObject.Find("Player").GetComponent<RaycastNPC>().OkeButton);
        Button niks = question3.transform.GetChild(1).transform.GetComponent<Button>();
        niks.onClick.AddListener(GameObject.Find("Player").GetComponent<RaycastNPC>().NiksButton);

    }
}