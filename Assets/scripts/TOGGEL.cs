using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOGGEL : MonoBehaviour
{
    bool isOn=false;
    [SerializeField] GameObject InformationPanel;

    public void togglePanel()
    {
        if(isOn)
        {
            InformationPanel.SetActive(false);
            isOn=false;
        }
        else
        {
            InformationPanel.SetActive(true);
            isOn=true;
        }
    }
}
