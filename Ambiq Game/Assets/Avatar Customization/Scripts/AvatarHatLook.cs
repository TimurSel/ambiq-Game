using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AvatarHatLook : MonoBehaviour
{
    //de lijsten van objecten die aangepast kunnen worden kan groter en kleiner worden.
    public List<GameObject> hats;

    public void Start()
    {
        //Ga door de lijst om de juiste avatar customization te laten zien
        GoThroughList(hatListPos, hats);
    }

    public int hatListPos = 0; //De positie waarin je bent in de lijst
    public void ChangeHat()
    {
        hatListPos += 1;
        if (hatListPos == hats.Count) //Als je positie verder gaat dan de lijst zelf. Ga dan weer terug naar het eerste in de lijst
        {
            hatListPos = 0;
        }

        GoThroughList(hatListPos, hats);
    }

    public void ChangeHatBack()
    {
        hatListPos -= 1;
        if (hatListPos <= -1) //Als je positie verder gaat dan de lijst zelf. Ga dan weer terug naar het eerste in de lijst
        {
            hatListPos = hats.Count - 1;
        }

        GoThroughList(hatListPos, hats);
    }

    public void GoThroughList(int _pos, List<GameObject> _list) //Positie dat in de lijst is en de lijst waarin je moet zoeken
    {
        for (int i = 0; i < _list.Count; i++) //Ga door de lijst heen
        {
            if (_pos == i) //Als de positie bij het object komt in de lijst, maak het dan active
            {
                _list[i].SetActive(true);
            }
            else _list[i].SetActive(false); //Als de positie niet overeenkomt met het object in de lijst maak het dan niet actief
        }
    }
}
