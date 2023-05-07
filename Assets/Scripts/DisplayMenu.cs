using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMenu : MonoBehaviour
{
    public void DisplayResolutionChosen(Int32 dropDownOrder)
    {
        switch (dropDownOrder)
        {
            case 0:
                if (Screen.currentResolution.width >= 3840 && Screen.currentResolution.height >= 2160) Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenMode.ExclusiveFullScreen);
                else Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenMode.FullScreenWindow);
                break;
            case 1:
                Screen.SetResolution(1280, 800, false);
                break;
            case 2:
                Screen.SetResolution(1360, 768, false);
                break;
            case 3:
                Screen.SetResolution(1440, 900, false);
                break;
            case 4:
                Screen.SetResolution(1680, 1050, false);
                break;
            case 5:
                Screen.SetResolution(1920, 1080, false);
                break;
            case 6:
                Screen.SetResolution(2560, 1080, false);
                break;
            case 7:
                Screen.SetResolution(2560, 1440, false);
                break;
            case 8:
                Screen.SetResolution(3440, 1440, false);
                break;
            case 9:
                Screen.SetResolution(3840, 2160, false);
                break;
        }

        //save dropDownOrder in playerprefs value
        PlayerPrefs.SetInt("DisplayResolution", dropDownOrder);
    }
}
