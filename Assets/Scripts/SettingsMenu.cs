using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private GameObject settingsMenuOBJ;
    public GameObject displayMenuOBJ;

    private void Start()
    {
        OpenCloseDisplay(false);
    }

    public void OpenCloseSettingsMenu(bool open)
    {
        settingsMenuOBJ.SetActive(open);
    }

    public void CloseSettingsMenu()
    {
        OpenCloseSettingsMenu(false);
    }

    public void OpenCloseDisplay(bool open)
    {
        displayMenuOBJ.SetActive(open);
    }
}
