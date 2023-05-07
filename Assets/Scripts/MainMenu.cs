using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Toolbox.Instance.GetSettingsManager().OpenOrCloseSettingsMenu(false);
    }

    public void PressedPlay()
    {
        //To do: Code to go to the main game scene here!
    }

    public void PressedSettings()
    {
        Toolbox.Instance.GetSettingsManager().OpenOrCloseSettingsMenu(true);
    }

    public void PressedQuit()
    {
        Application.Quit();
    }
}
