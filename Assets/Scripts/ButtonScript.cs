using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public bool ActiveInfo = false;
    public GameObject Info;

    public void PressButton()
    {
        if (ActiveInfo)
        {
            Info.SetActive(false);
            ActiveInfo = false;
        }
        else
        {
            Info.SetActive(true);
            ActiveInfo = true;
        }
    }
}
