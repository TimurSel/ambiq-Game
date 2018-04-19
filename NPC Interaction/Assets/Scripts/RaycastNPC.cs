using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastNPC : DialogueSystem
{
    public void Start()
    {
        cross.SetActive(true);
    }

    public void Update()
    {
        RayCast();
    }

    public void RayCast()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(cross.transform.position);
            if (Physics.Raycast(ray, out hit, 7f))
                if (hit.collider)
                {
                    OnDialogueStart(hit.collider.gameObject);
                }

        }
    }
}